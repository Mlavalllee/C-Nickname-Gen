// Variables
string FirstNameOutput = null;
string LastNameOutput = null;
string NicknameOutput = null;

//Nickname list
var Nicknames = new List<string> {
    "hacker", "the impeccable", "the strong", "pro", "tryhard", "loveable", "the ninja", "coder", "master"
};

// return back to option
var Again = "Menu";

// start
StartGen();

void StartGen()
{
    Console.WriteLine("Welcome to Nickname Generator");
    FName();
}

// Return to Menu Prompt
void ReturnPrompt()
{
    Console.WriteLine();
    Console.WriteLine("Chose one of the options");
    Console.WriteLine("1: Again");
    Console.WriteLine("2: Return to menu");
    Console.WriteLine("3: Quit");
    Console.WriteLine("Input:");
    int Input = int.Parse(Console.ReadLine());

    // check input
    if (Input == 1)
    {
        Console.Clear();
        switch (Again)
        {
            case "All":
                AllNicks();
                break;
            case "Add":
                AddNick();
                break;
            case "Remove":
                RemoveNick();
                break;
            case "Generate":
                GenerateNick();
                break;
        }
    }

    switch (Input)
    {
        case 2:
            Console.Clear();
            Menu();
            break;
        case 3:
            Console.Clear();
            break;
        default:
            Console.Clear();
            Console.WriteLine("no options chosen, returning to menu");
            Menu();
            break;
    }
}

// NO nicknames
void NoNicknames()
{
    Console.WriteLine("No Nicknames detected, please add one");
    Console.WriteLine("1: Add Nickname");
    Console.WriteLine("2: Menu");
    Console.WriteLine("Input:");
    int Input = int.Parse(Console.ReadLine());
    switch (Input)
    {
        case 1:
            Console.Clear();
            AddNick();
            break;
        case 2:
            Console.Clear();
            Menu();
            break;
        default:
            Console.Clear();
            Console.WriteLine("No option selected, retuning to menu");
            Menu();
            break;
    }
}

// Name inputs
void FName()
{
    // First Name Input
    Console.WriteLine("Input first name:");
    string Input = Console.ReadLine();
    FirstNameOutput = Input;
    Input = Input.Trim();

    // Check if first name is inputed
    switch (Input.Length)
    {
        case 0:
            Console.Clear();
            Console.WriteLine("First name not inputed, please input name");
            Console.WriteLine();
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
    Console.WriteLine("Input last name:");
    string Input = Console.ReadLine();
    LastNameOutput = Input;
    Input = Input.Trim();
    // Check if last name was inputed
    switch (Input.Length)
    {
        case 0:
            Console.Clear();
            Console.WriteLine("Last name not inputed, please input name");
            Console.WriteLine();
            LName();
            break;
        default:
            Console.Clear();
            Menu();
            break;
    }
}

//Menu
void Menu()
{
    // Options
    Console.WriteLine("Nickname Generator menu options:");
    Console.WriteLine("1: All nicknames");
    Console.WriteLine("2: add nickname");
    Console.WriteLine("3: Remove nickname");
    Console.WriteLine("4: Generate nickname");
    Console.WriteLine("5: change name");
    Console.WriteLine("6: Quit");
    Console.WriteLine("Input:");

    // Input
    int Input = int.Parse(Console.ReadLine());

    // check input
    switch (Input)
    {
        case 1:
            Console.Clear();
            AllNicks();
            break;
        case 2:
            Console.Clear();
            AddNick();
            break;
        case 3:
            Console.Clear();
            RemoveNick();
            break;
        case 4:
            Console.Clear();
            GenerateNick();
            break;
        case 5:
            Console.Clear();
            FName();
            break;
        case 6:
            Console.Clear();
            break;
        default:
            Console.Clear();
            Console.WriteLine("none of the avaliable options were selected.");
            Menu();
            break;
    }
}

// Output all possible nicknames
void AllNicks()
{
    Nicknames.Sort();
    if (Nicknames.Count == 0)
    {
        NoNicknames();
    }
    else
    {
        Console.WriteLine("Nicknames:");
        // Loop through all nicknames
        foreach (var nickname in Nicknames)
        {
            Console.WriteLine($"{FirstNameOutput} {nickname} {LastNameOutput}");
        }
    }
    Again = "All";
    ReturnPrompt();
}

// Add a nickname
void AddNick()
{
    Console.WriteLine("Please input custom nickname: ");
    string Input = Console.ReadLine();
    Input = Input.Trim();

    // check if duplicate nickname
    string duplicate = Input;
    duplicate.ToLower();
    foreach (var nickname in Nicknames)
    {
        nickname.Trim().ToLower();
        if (Equals(duplicate, nickname))
        {
            Console.Clear();
            Console.WriteLine("Duplicate nickname, please add a differnt one");
            Console.WriteLine();
            AddNick();
        }
    }
    switch (Input.Length)
    {
        // check if nickname is empty
        case 0:
            Console.Clear();
            Console.WriteLine("Input blank, Please put in nickname");
            AddNick();
            break;
        default:
            // add Nickname to list
            Console.Clear();
            Nicknames.Add(Input);
            Console.WriteLine("Nickname added to list");
            Again = "Add";
            ReturnPrompt();
            break;
    }
}

// Remove a nickname
void RemoveNick()
{
    Nicknames.Sort();
    bool NickRemoved = false;
    Console.WriteLine("List of nicknames:");
    foreach (var nickname in Nicknames)
    {
        Console.WriteLine(nickname);
    }
    Console.WriteLine("Input Nickname you want to remove (Cap sensitive): ");
    string Input = Console.ReadLine();
    foreach (var nickname in Nicknames)
    {
        if (Input == nickname)
        {
            Nicknames.Remove(Input);
            NickRemoved = true;
            break;
        }
    }
    if (NickRemoved == false)
    {
        Console.Clear();
        Console.WriteLine("Nickname not found, Please try again");
        Console.WriteLine("1: Retry");
        Console.WriteLine("2: Return to menu");
        Console.WriteLine("Input:");
        int Input2 = int.Parse(Console.ReadLine());
        switch (Input2)
        {
            case 1:
                Console.Clear();
                RemoveNick();
                break;
            case 2:
                Console.Clear();
                Menu();
                break;
            default:
                Console.Clear();
                Console.WriteLine("no option chosen, Returning to menu");
                Menu();
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Nickname Removed");
        Again = "Remove";
        ReturnPrompt();
    }
}

// Randomly generate a nickname
void GenerateNick()
{
    if (Nicknames.Count == 0)
    {
        NoNicknames();
    }
    else
    {
        // Random integer selector
        var random = new Random();
        int RandomNick = random.Next(Nicknames.Count);
        NicknameOutput = (Nicknames[RandomNick]);

        //Nickname output
        Console.WriteLine("your nickname is:");
        Console.WriteLine($"{FirstNameOutput} {NicknameOutput} {LastNameOutput}");
    }
    Again = "Generate";
    ReturnPrompt();
}