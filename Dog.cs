public class Dog : IAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Golos()
    {
        Console.WriteLine("���!");
    }

    public void Poroda()
    {
        Console.WriteLine("������ ������: ͳ������ �������");
    }
}
