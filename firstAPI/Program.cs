var builder = WebApplication.CreateBuilder(args);


List<Anime> AnimeRecords = [
    new Anime(1,"Your Name", new DateOnly(2022,10,1)),
    new Anime(2,"Your Name", new DateOnly(2022,10,1)),
    new Anime(3,"Your Name", new DateOnly(2022,10,1)),
    new Anime(4,"Your Name", new DateOnly(2022,10,1))
];

// Anime[] AnimeRecordss = [
//     new Anime(1,"Special Name", new DateOnly(2022,10,1)),
//     new Anime(2,"Special Name", new DateOnly(2022,10,1)),
//     new Anime(3,"Special Name", new DateOnly(2022,10,1)),
//     new Anime(4,"Special Name", new DateOnly(2022,10,1))
// ];


// var AnimeRecording = new List<Anime> {
//     new Anime(1,"Special Name", new DateOnly(2022,10,1)),
//     new Anime(2,"Special Name", new DateOnly(2022,10,1)),
//     new Anime(3,"Special Name", new DateOnly(2022,10,1)),
//     new Anime(4,"Special Name", new DateOnly(2022,10,1))
// };


var app = builder.Build();

const string GetAnimeEndPointName = "GetAnime";

app.MapGet("/", () => "hello world");



app.MapGet("anime", () => AnimeRecords);

app.MapGet("anime/{id}", (int id) =>
{
    return AnimeRecords.Find(anime => anime.Id == id);
}).WithName(GetAnimeEndPointName);


app.MapPost("anime", (CreateAnimeDTO p) =>
{

    Anime dto = new Anime(AnimeRecords.Count + 1, p.Name, p.Date);
    AnimeRecords.Add(dto);

    return Results.CreatedAtRoute(GetAnimeEndPointName, new { id = dto.Id }, dto);
});

app.MapPut("anime/{id}", (int id, UpdateAnimeDTO update) =>
{

    var index = AnimeRecords.FindIndex(anime => anime.Id == id);

    if (index != -1)
    {

        AnimeRecords[index] = new Anime(
            id,
            update.Name,
            update.Date
        );

    }

    return Results.NoContent();

});

app.MapDelete("anime/{id}", (int id) =>
{

    AnimeRecords.RemoveAll(anime => anime.Id == id);





    return Results.NoContent();

});

app.Run();
