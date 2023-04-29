using HomeWorkFour;
using HomeWorkFour.Entities;

//Create a class Person and a class Dog. Each Person can have one or more dogs. Create properties according some of the requirements below. Create a static db, static lists of the two classes.
//Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
//Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
//Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
//Find and print all Freddy`s dogs names older than 1 year
//Find and print Nathen`s first dog
//Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER





void Print<T>(List<T> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}


List<string> firstNamesStartWithR = LocalDb.Persons
    .OrderByDescending(x => x.Age)
    .Where(x => x.FirstName.StartsWith("R"))
    .Select(x =>$"{x.Age} {x.FirstName}")
    .ToList();

Console.WriteLine("Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER: ");
Print(firstNamesStartWithR);


List<string> brownDogsNames = LocalDb.Dogs
    .Where(x => x.Color == "brown" && x.Age > 3)
    .OrderBy(x => x.Age).Select(x => $"{x.Age} {x.Name}")
    .ToList();

Console.WriteLine("Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER: ");
Print(brownDogsNames);

List<string> personWithMoreThanTwoDogs = LocalDb.Persons
    .OrderByDescending(x => x.FirstName)
    .Where(x => x.Dogs.Count > 2)
    .Select(x => $"{x.FirstName}")
    .ToList();

Console.WriteLine("Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER: ");
Print(personWithMoreThanTwoDogs);

List<string> freddyDogsNames = LocalDb.Persons
    .Where(x => x.FirstName == "Freddy")
    .SelectMany(x => x.Dogs)
    .Where(x => x.Age > 1).Select(x => $"{x.Name}")
    .ToList();

Console.WriteLine("Find and print all Freddy`s dogs names older than 1 year: ");
Print(freddyDogsNames);

Dog? nathenFirstDog = LocalDb.Persons
    .Where(x => x.FirstName == "Nathen")
    .SelectMany(x => x.Dogs)
    .FirstOrDefault();

Console.WriteLine("Find and print Nathen`s first dog: ");
Console.WriteLine($"{nathenFirstDog?.Name}");

List<string> whiteDogsNames = LocalDb.Persons
    .Where (x => x.FirstName == "Cristopher" || x.FirstName == "Freddy" || x.FirstName == "Erin" || x.FirstName == "Amelia")
    .SelectMany (x => x.Dogs)
    .Where(x => x.Color == "white")
    .OrderBy(x => x.Name)
    .Select(x => $"{x.Name}")
    .ToList() ;

Console.WriteLine("Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER: ");
Print(whiteDogsNames);