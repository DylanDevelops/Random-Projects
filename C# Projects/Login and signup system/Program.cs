// Brings back to beginning
bool loopBack = true;

// commands
string help = "-help";
string signUp = "-signup";
string login = "-login";
string logOut = "-logout";
string close = "-close";

// storage of values
string email = "notEntered";
string password = "notEntered";

//bools
bool isLoggedIn = false;

while(loopBack)
{
    Console.WriteLine($"Please choose a command. Type [{help}] if you need help.");
    string answer1 = Console.ReadLine();

    if(answer1 == signUp)
    {
        Console.WriteLine("Please Enter an Email:");
        email = Console.ReadLine();

        Console.WriteLine("\nPlease Enter a Password:");
        password = Console.ReadLine();

        Console.WriteLine($"\nYour email is: `{email}` and your password is `{password}`.\nIs this okay? Please type `yes` if the information is correct.");
        string yesOrNo = Console.ReadLine();

        if(yesOrNo == "yes")
        {
            isLoggedIn = true;
            Console.WriteLine($"You are successfully logged in. If you wish to log out, type {logOut}");

            if(isLoggedIn)
            {
                string logOutMessage = Console.ReadLine();

                if(logOutMessage == logOut)
                {
                    Console.WriteLine($"Logging out of {email}...");
                    isLoggedIn = false;
                }
            }
        }
        else if(yesOrNo == "no")
        {
            loopBack = false;
        }
    }
    else if(answer1 == login)
    {
        Console.WriteLine("\nPlease Enter Email:");
        string possibleEmail = Console.ReadLine();
        
        Console.WriteLine("\nPlease Enter Password:");
        string possiblePassword = Console.ReadLine();

        if(possibleEmail == email && possiblePassword == password)
        {
            isLoggedIn = true;
            Console.WriteLine($"You are successfully logged in. If you wish to log out, type {logOut}");

            if(isLoggedIn)
            {
                string logOutMessage = Console.ReadLine();

                if(logOutMessage == logOut)
                {
                    Console.WriteLine($"Logging out of {email}...");
                    isLoggedIn = false;
                }
            }
        } 
        else if(possibleEmail != email || possiblePassword != password)
        {
            Console.WriteLine("No account found. You must make an account.");
        }
    }
    else if(answer1 == help)
    {
        Console.WriteLine($"The current commands are {login} or {signUp}\n");
    }
    else if(answer1 == close)
    {
        loopBack = false;
    }
    else
    {
        Console.WriteLine("Not a valid command.\nPlease try again.\n");
    }
}

loopBack = false;