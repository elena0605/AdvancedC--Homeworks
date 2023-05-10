//Create a Dog class with :
//Name, Age, Color
//Let the user input these parameters from a console application
//Create a new Dog object from the inputs and write it as a json in a new file on the file system
//The content of the json should be array
//Create a method that reads and prints in the console all the dogs from the txt file

using HomeWorkFive;
using Newtonsoft.Json;


Console.Write("Enter dog's name: ");
string dogName = Console.ReadLine();

Console.Write("Enter dog's age: ");
int dogAge = int.Parse(Console.ReadLine());

Console.Write("Enter dog's color: ");
string dogColor = Console.ReadLine();



List<Dog> dogs = new List<Dog>()
{
    new Dog (dogName, dogColor, dogAge),
    
};
  

string folderPath = "../../../NewFolder";
string filePath = folderPath + "/DogsData.Json";


if(!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

if(!File.Exists(filePath))
{
    File.Create(filePath).Close();
}


void writeToJson (string json)
{
    using(StreamWriter sw = new StreamWriter(filePath, true))
    {
        sw.WriteLine(json); 
    }  
}

void ReadFromJson()
{
    using(StreamReader sr = new StreamReader(filePath))
    {
        Console.WriteLine(sr.ReadToEnd()); 
    }
}

string dogsInJson = JsonConvert.SerializeObject(dogs);
List<Dog> deserialiseDogs = JsonConvert.DeserializeObject<List<Dog>>(dogsInJson);



writeToJson(dogsInJson);
ReadFromJson();

foreach (Dog dog in deserialiseDogs)
{
    Console.WriteLine( $"{dog.Name}, {dog.Color}, {dog.Age}");
}

