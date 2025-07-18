


class Human
{

    private int age;
    private string name;

    private double height;



    public double Height
    {
        get { return height; }

        set { height = value; }

    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    public int Age
    {

        get { return age; }
        set { age = value; }

    }



    public void DispalyInfo()
    {
        Console.WriteLine("the name is. :" + name + ", the age is : " + age + ", the height is : " + height);
    }





}