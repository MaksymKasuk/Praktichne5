public class Cat : IAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Golos()
    {
        Console.WriteLine("���!");
    }

    public void Poroda()
    {
        Console.WriteLine("ʳ��� ������: ѳ������");
    }
}
