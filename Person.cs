namespace powtorzenie;

public class Person
{
    public static List<Person> People = new List<Person>();
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Person() { }
    
    public Person(string name, int age)
    {
        Id = People.Max(x => x.Id) + 1;
        Name = name;
        Age = age;
    }
}