Console.WriteLine("What is your name?");
string name = Console.ReadLine();

string greeting = name switch 
{
    "Mercedez" => "Hello Mercedez",
    _ => "Who are you?"
};
Console.WriteLine(greeting);

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

Console.WriteLine("How were you feeling yesterday on a scale of 1-5?");
string ratingInput = Console.ReadLine();
int yesterdayRating = int.Parse(ratingInput);

string response = yesterdayRating switch
{
    1 => "Dang. Maybe today will suck less ass",
    2 => "Oh, sorry to hear your day was shite",
    3 => "Noice, sounds pretty okayish",
    4 => "Sweet buscuits! We love!",
    5 => "Siiiiiiiick, SMASHING!",
    _ => "You didn't do it right you fat bitch"
};

Console.WriteLine(response);