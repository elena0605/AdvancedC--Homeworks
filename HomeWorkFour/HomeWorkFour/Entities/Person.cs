namespace HomeWorkFour.Entities
{
    public class Person
    {
        public string FirstName { get; set; } = String.Empty;   
        public string LastName { get; set; } = String.Empty;    
        public int Age { get; set; }
        public List<Dog> Dogs { get; set; } 

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;  
            Dogs = new List<Dog>();
        }
    }
}
