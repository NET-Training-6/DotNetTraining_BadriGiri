namespace Animal;
class Animal
{
    public string name;
    public byte age;
    public float weight;
    public bool canFly;
    public string color;

    public void MethodsAnimal()
    {
        Console.WriteLine($"name: {name}\n, age: {age}\n, weight: {weight}\n, CanFly: {canFly}\n, Color:{color}");
        Console.WriteLine("\n");
    }


}