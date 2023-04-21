using TaskOne.Entities.Interfaces;

namespace TaskOne.Entities
{
    public abstract class Animal : IAnimal

    {
       public string Name { get; set; } = string.Empty;
       public int Age { get; set; }
       public string Breed { get; set; } = string.Empty;
       public string Color { get; set; } = string.Empty;

       public Animal(string name, int age, string breed, string color)
        {
            Name = name;
            Age = age;  
            Breed = breed;
            Color = color;

        }


        public abstract void PrintAnimal();

    }
}
