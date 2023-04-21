using TaskOne.Entities.Interfaces;

namespace TaskOne.Entities
{
    public class Cat : Animal, ICat
    {
        public bool IsSmart { get; set; }

        public Cat(string name, int age, string breed, string color, bool isSmart) : base(name,age,breed,color) 
        {
            IsSmart = isSmart;
        }
        public void Eat(string food)
        {
            if(food.ToUpper() == "fish".ToUpper() &&  IsSmart)
            {
                Console.WriteLine( $"{food} is {Name}'s favorite food and because it's a smart cat it will eat it just by its own.");
            }
            else
            {
                Console.WriteLine($"{Name} is not very smart cat so will let other cats to join and  taste the {food}");
            }
             
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This cat name is {Name}, it's a {Breed}, has a {Color} color and is {Age} years old. ");

        }
    }
}
