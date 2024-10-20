public class Cat : IAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Golos()
    {
        Console.WriteLine("Мяу!");
    }

    public void Poroda()
    {
        Console.WriteLine("Кішка породи: Сіамська");
    }
}
