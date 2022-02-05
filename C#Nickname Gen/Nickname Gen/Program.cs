// Variables
string FirstNameOutput = " ";
string LastNameOutput = " ";
string NicknameOutput = " ";

//Nickname array
string[]

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
    string Input = Console.ReadLine();
    FirstNameOutput = Input;

    // Check if first name is inputed
    switch (Input.Length)
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
    // Last Name Input
    Console.WriteLine("Input last name: ");
    string Input = Console.ReadLine();
    LastNameOutput = Input;

    // Check if last name was inputed
    switch (Input.Length)
    {
        case 0:
            Console.WriteLine("Last name not inputed, please input name");
            Console.WriteLine(" ");
            LName();
            break;
        default:
            Menu();
            break;
    }
}

void Menu()
{
    // Options
    Console.WriteLine("Nickname Generator menu options:");
    Console.WriteLine("1: All nicknames");
    Console.WriteLine("2: add nickname");
    Console.WriteLine("3: Remove nickname");
    Console.WriteLine("4: Generate nickname");
    Console.WriteLine("5: change name");

    // Input
    string Input = Console.ReadLine();

    // Menu output
    switch (Input)
    {
        case 1:
            AllNicks();
            break;
        case 2:
            AddNick();
            break;
        case 3:
            RemoveNick();
            break;
        case 4:
            GenerateNick();
            break;
        case 5:
            FName();
            break;
        default:
            Console.WriteLine("none of the avaliable options selected,");
            GeneratorMenu();
            break;

    }
}

//nickname array


//string[] Nickname = {"the Strong", "The excellent", "The ingenious " };

//out all possible nicknames



//Nickname output
Console.WriteLine($" your nickname is {FirstName} {test} {LastName}");

