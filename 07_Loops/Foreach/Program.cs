string instructorName = "Jacob";
string[] instructors = new string[] {"Adam", "Kate", instructorName};
//List<string>

//foreach (declaredIterator in enumberableCollection){body}

foreach(string name in instructors)
{
    Console.WriteLine($"Hello {name}");
}

//String are collections or characters, and can be iterated over in foreach's
foreach(char letter in instructorName){
    if(letter == 'c'){
        Console.WriteLine('k');
    }
    else
    Console.WriteLine(letter);
}