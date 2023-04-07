internal class Developer
    {

    public string Name;
    public string Surname;
    public int Age;
    public double Salary;
    public string Position;

    public Developer():this("Guest")
    {

    }
    public Developer(string name)
    {
        this.Name = name;
    }
    public Developer(string name, string surname) : this(name)
    {
        this.Surname = surname;
    }
    public Developer(string name, string surname, int age, double salary, string position) : this(name, surname)
    {
        Age = age;
        Salary = salary;
        Position = position;
    }

    public void GetAllInfo()
    {
        Console.WriteLine($"{Name} {Surname} {Age} {Salary} {Position}");
    }
    
    }