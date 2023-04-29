using HomeWorkFour.Entities;

namespace HomeWorkFour
{
    public static class LocalDb
    {
        public static List<Person> Persons = new List<Person>()
        {
            new Person("Mary","Bean", 20),
            new Person("Rob", "Peas", 30),
            new Person("Ronn","Weasley",25),
            new Person("Rocky","Balboa", 19),
            new Person("Freddy", "March",56),
            new Person("Nathen", "Marks",89),
            new Person("Cristopher", "Columbo",100),
            new Person("Erin", "Brockovich",60),
            new Person("Amelia", "Earhart",70)

        };


        public static List<Dog> Dogs = new List<Dog>()
        {
            new Dog("Max","brown",9),
            new Dog("Smiley","cream",2),
            new Dog("Buddy","white",4),
            new Dog("Charlie","black",1),
            new Dog("Bailey","gold",3),
            new Dog("Luke","black",10),
            new Dog("Copper","black",8),
            new Dog("Duke","white",8),
            new Dog("Bella","gray",1),
            new Dog("Coco","brown",4),
            new Dog("Juno","white",5),
            new Dog("Archie","brown",1),
            new Dog("Leo","brown",7),

        };

        static LocalDb ()
        {
            Persons[0].Dogs = new List<Dog>() { Dogs[0] };
            Persons[1].Dogs = new List<Dog>() { Dogs[11]}; 
            Persons[2].Dogs = new List<Dog>() { Dogs[1] };
            Persons[3].Dogs = new List<Dog>() { Dogs[0], Dogs[2]};
            Persons[4].Dogs = new List<Dog>() { Dogs[1]};
            Persons[5].Dogs = new List<Dog>() { Dogs[3], Dogs[4], Dogs[5]};
            Persons[6].Dogs = new List<Dog>() { Dogs[6], Dogs[7], Dogs[2]};
            Persons[7].Dogs = new List<Dog>() { Dogs[8],Dogs[9], Dogs[10]};
            Persons[8].Dogs = new List<Dog>() { Dogs[12]};
        }


    }
}
