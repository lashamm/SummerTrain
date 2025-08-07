////                          practice 8



string word;
int number;

Console.WriteLine("Enter a word number:");
word = Console.ReadLine();
Console.Clear();

if (word == "one")
{
        number = 1;
}
else if (word == "two")
{
    number = 2;
}
else if (word == "three")
{
    number = 3;
}
else if (word == "four")
{
    number = 4;
}
else if (word == "five")
{
    number = 5;
}
else if (word == "six")
{
    number = 6;
}
else if (word == "seven")
{
    number = 7;
}
else if (word == "eight")
{
    number = 8;
}
else if (word == "nine")
{
    number = 9;
}
else if (word == "ten")
{
    number = 10;
}
else
{
    Console.WriteLine("Invalid word.");
    return;
}










////                            practice 7

//int firstNumber;
//int validationNumber;

//Console.WriteLine("Enter a number:");
//firstNumber = int.Parse(Console.ReadLine());
//Console.Clear();

//Console.WriteLine("Enter a validation number:");
//validationNumber = int.Parse(Console.ReadLine());
//Console.Clear();

//if (firstNumber < 0 || validationNumber < 0)
//{
//    Console.WriteLine("Numbers cannot be negative.");
//    return;
//}

//else if (firstNumber == validationNumber)
//{
//    Console.WriteLine("The numbers are equal.");
//}
//else if (firstNumber > validationNumber)
//{
//    Console.WriteLine($"{firstNumber} is greater than {validationNumber}.");
//}
//else
//{
//    Console.WriteLine($"{firstNumber} is less than {validationNumber}.");
//}











////                            practice 6


//string firstName;
//string lastName;
//int age;
//string email;
//string password;
//string confirm;

//Console.WriteLine("Enter your firstname");
//firstName = Console.ReadLine();
//Console.Clear();

//Console.WriteLine("Enter your lastname");
//lastName = Console.ReadLine();
//Console.Clear();

//Console.WriteLine("Enter your age");
//age = int.Parse(Console.ReadLine());
//Console.Clear();
//if (age < 0 || age > 120)
//{
//    Console.WriteLine("Invalid age.");
//    return;
//}

//Console.WriteLine("Enter your email");
//email = Console.ReadLine();
//Console.Clear();

//Console.WriteLine("Enter your password");
//password = Console.ReadLine();
//Console.Clear();

//Console.WriteLine("Confirm your password");
//confirm = Console.ReadLine();
//Console.Clear();

//if (password != confirm)
//{
//    Console.WriteLine("Passwords do not match.");
//    return;
//}
//else
//{
//    Console.WriteLine($"" +
//        $"\nYour fisrtname is {firstName}," +
//        $"\nYour lastname is {lastName}," +
//        $"\nYou are {age} years old," +
//        $"\nYour password is {password}");
//}













////                               practice 5

//using SummerTrain;

//int id;
//string name;
//decimal deposit;
//decimal withdrawal;
//decimal balance;


//Console.WriteLine("Enter a starting balance");
//balance = decimal.Parse(Console.ReadLine());
//Console.Clear();
//if (balance < 0)
//{
//    Console.WriteLine("Balance cannot be negative.");
//    return;
//}


//Console.WriteLine("Enter your Id:");
//id = int.Parse(Console.ReadLine());
//Console.Clear();
//if (id < 0)
//{
//    Console.WriteLine("Wrong Id.");
//    return;
//}

//Console.WriteLine("Enter your name:");
//name = Console.ReadLine();
//Console.Clear();

//Console.WriteLine("Enter your deposit amount:");
//deposit = decimal.Parse(Console.ReadLine());
//Console.Clear();
//if (deposit < 0)
//{
//    Console.WriteLine("Deposit cannot be negative.");
//    return;
//}

//Console.WriteLine("Enter your withdrawal amount:");
//withdrawal = decimal.Parse(Console.ReadLine());
//Console.Clear();
//if (withdrawal < 0)
//{
//    Console.WriteLine("Withdrawal cannot be negative.");
//    return;
//}

//Bank bank = new Bank(id, name, deposit, withdrawal, balance);

//bank.DepositMoney(deposit);
//bank.WithdrawMoney(withdrawal);
//bank.PrintInfo();
















//                              practice 4



//int num1;
//int num2;
//char operation;

//Console.WriteLine("Enter first number:");
//num1 = int.Parse(Console.ReadLine());
//Console.Clear();

//Console.WriteLine("Enter second number:");
//num2 = int.Parse(Console.ReadLine());
//Console.Clear();

//Console.WriteLine("Enter operation (+, -, *, /):");
//operation = char.Parse(Console.ReadLine());
//Console.Clear();

//if (operation == '+')
//{
//    int sum = num1 + num2;
//    Console.WriteLine($"{num1} + {num2} is {sum}");
//}
//else if (operation == '-')
//{
//    int difference = num1 - num2;
//    Console.WriteLine($"{num1} - {num2} is {difference}");
//}
//else if (operation == '*')
//{
//    int product = num1 * num2;
//    Console.WriteLine($"{num1} * {num2} is {product}");
//}
//else if (operation == '/')
//{
//    if (num2 != 0)
//    {
//        double quotient = (double)num1 / num2;
//        Console.WriteLine($"{num1} / {num2} is {quotient}");
//    }
//    else
//    {
//        Console.WriteLine("Cannot divide by zero.");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid operation.");
//}











////                                practice 3

//using SummerTrain;

//string name;
//string surname;
//DateTime age;
//string gender;
//string email;
//int id;

//Console.WriteLine("Enter your Id");
//id = int.Parse(Console.ReadLine());
//Console.Clear();
//if (id < 0)
//{
//    Console.WriteLine("Id cannot be negative.");
//    return;
//}


//Console.WriteLine("Enter your name");
//name = Console.ReadLine();
//Console.Clear();

//Console.WriteLine("Enter your surname");
//surname = Console.ReadLine();
//Console.Clear();

//Console.WriteLine("Enter your age (YYYY-MM-DD)");
//age = DateTime.Parse(Console.ReadLine());
//Console.Clear();

//Console.WriteLine(
//    $"Enter yor Gender: Male or Female"
//    );
//gender = Console.ReadLine().ToLower();
//Console.Clear();
//if (gender != "female" || gender != "male")
//{
//    Console.WriteLine("Error");
//}


//else { 

//    Console.WriteLine("Enter your email");
//email = Console.ReadLine();
//Console.Clear();

//Person person = new Person(id, name, surname, age, gender, email);

//person.PrintInfo();
//};














//                                 practice 2

//string name;
//string surname;
//int age;
//string address;

//Console.WriteLine("What's your name?");
//name = Console.ReadLine();
//Console.WriteLine("What's your surname?");
//surname = Console.ReadLine();
//Console.WriteLine("How old are you?");
//age = int.Parse(Console.ReadLine());
//Console.WriteLine("Where do you live?");
//address = Console.ReadLine();

//Console.Clear();

//Console.WriteLine($"Your name is {name} {surname}, you are {age} years old and you live in {address}.");








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