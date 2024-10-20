public class Dog : IAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Golos()
    {
        Console.WriteLine("Гав!");
    }

    public void Poroda()
    {
        Console.WriteLine("Собака породи: Німецька вівчарка");
    }
}
