//                                 practice 2

string name;
string surname;
int age;
string address;

Console.WriteLine("What's your name?");
name = Console.ReadLine();
Console.WriteLine("What's your surname?");
surname = Console.ReadLine();
Console.WriteLine("How old are you?");
age = int.Parse(Console.ReadLine());
Console.WriteLine("Where do you live?");
address = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Your name is {name} {surname}, you are {age} years old and you live in {address}.");








//                                         practice 1


//int response;
//Console.WriteLine(
//    $"Press 1 to choose color red." +
//    $"Press 2 to choose color blue." +
//    $"Press 3 to choose color green." +
//    $"Press 4 to choose color white." +
//    $"Press 5 to choose color yellow."
//    );
//response = int.Parse(Console.ReadLine());

//if(response == 1)
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//else if(response == 2)
//{
//    Console.BackgroundColor = ConsoleColor.Blue;
//}
//else if(response == 3)
//{
//    Console.BackgroundColor = ConsoleColor.Green;
//}
//else if(response == 4)
//{
//    Console.BackgroundColor = ConsoleColor.White;
//}
//else if(response == 5)
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//else
//{
//    Console.WriteLine("Invalid choice, defaulting to black.");
//    Console.BackgroundColor = ConsoleColor.Black;
//}