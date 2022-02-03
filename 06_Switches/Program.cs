Console.WriteLine("What is your name?");
string name = Console.ReadLine();
switch(name)
{
   case "Mercedez":
   Console.WriteLine("Nice to meet you " + name);
   break;
    default:
   break;
}


Console.WriteLine("How are you feeling today on a scale of 1-5? ");
string feelingRating = Console.ReadLine();

switch (feelingRating)
{
    case "5": 
    Console.WriteLine("That is great to hear!");
    break;
    case "4":
    Console.WriteLine("Good Stuff!");
    break;
    case "3":
    Console.WriteLine("Hope things improve!");
    break;
    case "2":
    Console.WriteLine("Oh no, Sorry to hear that!");
    break;
    case "1":
    Console.WriteLine("Dang, that sucks balls");
    break;
    default:
    Console.WriteLine("Sorry you am idiot, put a number 1-5!");
    break;
}