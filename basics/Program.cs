// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



class Pradeep
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello pradeep");

        bool value = int.TryParse(Console.ReadLine(), out int number);

        if (value)
        {
            Console.WriteLine("Right value : " + number);
        }
        else
        {
            Console.WriteLine("Wrong number : ");
        }


        Console.WriteLine("The value is : " + value);

        int num = 12;
        string naem = "Pradeep";
        bool isValid = true;
        char c = 'A';


        Console.WriteLine(num);
        Console.WriteLine(naem);
        Console.WriteLine(isValid);
        Console.WriteLine(c);



        Human h = new();



        h.Name = "Pradeep";
        h.Age = 12;


        h.DispalyInfo();


    }
}

