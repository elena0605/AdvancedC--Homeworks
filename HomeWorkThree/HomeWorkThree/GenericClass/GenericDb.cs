using HomeWorkThree.AbstractClass;
using HomeWorkThree.Helper;

namespace HomeWorkThree.GenericClass
{
    public static class GenericDb<T> where T : BaseEntity
    {

        public static List<T> Db;

        static GenericDb()
        {
            Db = new List<T>();
        }

        public static void PrintAll()
        {
            foreach (T item in Db)
            {
                
                Console.WriteLine("Brand Name: ");
                item.Brand.ChangeColorText(ConsoleColor.Blue, ConsoleColor.DarkYellow);
                Console.WriteLine("Model Name: ");
                item.Model.ChangeColorText(ConsoleColor.Yellow, ConsoleColor.DarkGreen);
                Console.WriteLine("\n");
            }

        }
        public static void Insert(T item)
        {
            Db.Add(item);
           

        }

        public static T GetById(int id) => Db.FirstOrDefault(x => x.Id == id);

    }
}
