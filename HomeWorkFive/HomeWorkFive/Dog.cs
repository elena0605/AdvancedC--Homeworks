namespace HomeWorkFive
{
    public  class Dog
    {
        public string Name { get; set; } = String.Empty;
        public string Color { get; set; } = String.Empty;
        public int Age { get; set; }    

        public Dog(string name, string color, int age) {
            Name = name;    
            Color = color;  
            Age = age;
        }
    }
}
