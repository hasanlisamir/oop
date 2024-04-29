namespace OOPintro;

class Program
{
    static void Main(string[] args)
    {

        /*

                Person person1 = new Person();
                Console.WriteLine(person1.Name);
                person1.Id = 1;
                person1.Name ="samir";

                person1.Surname = "hasanli";
                person1.Birthday = DateTime.Parse("08/12/1988");
                person1.IsMarried = true;
                Console.WriteLine(person1.Name);
                Person person2 = new Person();

                person1.Id = 2;
                person1.Name = "mahir";
                person1.Surname = "hasanli";
                person1.Birthday = DateTime.Parse("09/15/1988");
                person1.IsMarried = false;
                Console.ReadLine();*/

        Car car1 = new Car();
        car1.Id = 3;
        car1.Model = "mersedes";

        car1.Motor = 2;
        car1.Year = 1998;
        car1.Colour = "red";


        Car car2 = new Car();


        car2.Id = 4;
        car2.Model = "mersedes";

        car2.Motor = 3;
        car2.Year = 1998;
        car2.Colour = "black";
        Console.WriteLine(car1.Model);
        Console.Read();


        Ev ev1 = new Ev();

    }




}

