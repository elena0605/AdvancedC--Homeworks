using TaskOne.Entities.Interfaces;

namespace TaskOne.Entities
{
    public class Dog : Animal , IDog
    {
        public bool IsHunting { get; set; }


        public Dog(string name, int age, string breed, string color ,bool ishunting) : base(name, age, breed,color)
        {
            IsHunting = ishunting;
        }

        public void Bark()
        {
            if(IsHunting)
            {
                Console.WriteLine($"{Name} is barking constantly when he is hunting");
            }
            else
            {
                Console.WriteLine($"{Name} is calm and he is not barking.");
            }
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This Dog is called {Name}, it's {Age} years old, has a {Color} color, and is of {Breed} breed");
            
        }
    }
}
