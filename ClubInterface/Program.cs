using System;

interface IClub
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
}

class Program
{
    class ClubMember : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Age (in years)
        public double age { get; set; }
        // Weight (in US pounds)
        public double weight { get; set; }
        // Height (in feet)
        public double height { get; set; }

        public ClubMember()
        {
            Id = 0;
            FirstName = "none";
            LastName = "none";
            age = weight = height = 0;
        }
        public ClubMember(int _id, string _fname, string _lname, double _age, double _weight, double _height)
        {
            Id = _id;
            FirstName = _fname;
            LastName = _lname;
            age = _age;
            weight = _weight;
            height = _height;
        }
        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
    }
    static public void Main(string[] args)
    {
        ClubMember member1 = new ClubMember(89, "Michael", "Rodriguez", 23, 159.45, 5.3);

        Console.WriteLine("Club Member #{0}", member1.Id);
        Console.WriteLine("ID: {0}", member1.Id);
        Console.WriteLine("Name: {0}", member1.Fullname());
        Console.WriteLine("First Name: {0}", member1.FirstName);
        Console.WriteLine("Last Name: {0}", member1.LastName);
        Console.WriteLine("Age (in whole years): {0}", Math.Round(member1.age));
        Console.WriteLine("Weight (in pounds): {0}", member1.weight);
        Console.WriteLine("Height (in feet): {0}", member1.height);
    }
}