
// Variables
string FirstName = " ";
string LastName = " ";
string Nickname = " ";

// start
StartGen();

void StartGen()
{
    Console.WriteLine("Welcome to Nickname Generator");
    FName();
}

void FName() 
{
    // First Name Input
    Console.WriteLine("Input first name: ");
    string Input1 = Console.ReadLine();
    FirstName = Input1;

    // check if first name is inputed
    switch (FirstName.Length)
    {
        case 0:
            Console.WriteLine("First name not inputed, please input name");
            Console.WriteLine(" ");
            FName();
            break;
        default:
            LName();
            break;
    } 
}

void LName() 
{  
    //Last Name Input
    Console.WriteLine("Input last name: ");
    string Input2 = Console.ReadLine();
    LastName = Input2;

    // Check if last name was inputed
    switch(LastName.Length)
    {
        case 0:
            Console.WriteLine("Last name not inputed, please input name");
            Console.WriteLine(" ");
            LName();
            break;
        default:
            GeneratorMenu();
            break;
    }
}

void GeneratorMenu()
{
    Console.WriteLine("Nickname Generator menu options:");
    Console.WriteLine("1: All nicknames");
    Console.WriteLine("2: ");
}





//nickname list

//string[] Nickname = {"the Strong", "The excellent", "The ingenious " };

//out all possible nicknames



//ouput nickname
Console.WriteLine($" your nickname is {FirstName} {test} {LastName}");

