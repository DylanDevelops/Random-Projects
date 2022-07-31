//emails
string email = "hi@hi.com";

//passwords
string password = "hello";

// quick store of information
string? enteredEmail;
string? enteredPassword;

//responses
string? enteredAnswer;
string? enteredAnswer2;
int withdrawAmount;
int depositAmount;

//bools
bool loggedIn = false;
bool verified = false;

//code words
string? withdraw = "WITHDRAW";
string? deposit = "DEPOSIT";
string? checkBalance = "BALANCE";
string? logout = "LOGOUT";

//money
int money = 0;

while(!verified && !loggedIn)
{
    Console.WriteLine("Welcome to this totally secure ATM!\nYou can close this application by typing `CLOSE` or begin the login process by entering your email:");
    enteredEmail = Console.ReadLine();

    if(enteredEmail == "CLOSE" || enteredEmail == "close")
    {
        Environment.Exit(0);
    }

    Console.WriteLine($"\nPlease enter the password associated with {enteredEmail}:");
    enteredPassword = Console.ReadLine();

    Console.WriteLine($"You used the email: `{enteredEmail}` and the password: `{enteredPassword}`.\nIs this correct? Type `yes` or `no`");
    enteredAnswer = Console.ReadLine();

    if(enteredAnswer == "yes")
    {
        verified = true;

        if(enteredEmail == email && enteredPassword == password)
        {
            loggedIn = true;
            Console.WriteLine($"\nLogging in...\nYou are now logged in as {email}.");
        } else {
            loggedIn = false;
            verified = false;

            Console.WriteLine("\nCould not find account on record. Please try again.\n");
        }
    } else {
       verified = false;
       loggedIn = false;
       Console.WriteLine("\nPlease re-enter your email and password.\n");
    }
}

while(loggedIn && verified)
{
    Console.WriteLine($"\nPlease make a `WITHDRAW` or `DEPOSIT`. You can also check your balance by typing `BALANCE`. You can also log out by typing `LOGOUT`.");
    enteredAnswer2 = Console.ReadLine();

    if(enteredAnswer2 == checkBalance)
    {
        CheckBalance();
    }
    else if(enteredAnswer2 == logout)
    {
        Console.WriteLine($"\nLogging out...\n");
        Logout();
    }
    else if(enteredAnswer2 == withdraw)
    {
        Console.WriteLine("\nHow much would you like to withdraw? (Whole numbers only)");
        withdrawAmount = Convert.ToInt32(Console.ReadLine());

        Withdraw(withdrawAmount);
    }
    else if(enteredAnswer2 == deposit)
    {
        Console.WriteLine("\nHow much would you like to deposit? (Whole numbers only)");
        depositAmount = Convert.ToInt32(Console.ReadLine());

        Deposit(depositAmount);
    } else {
        Console.WriteLine("\nUnknown Request. Please try again.\n");
    }
}

void CheckBalance()
{
    Console.WriteLine($"\nYou currently have a total of ${money} in your account.\n");
}

void Logout()
{
    verified = false;
    loggedIn = false;
}

void Withdraw(int amountToDeduct)
{
    money -= amountToDeduct;
    Console.WriteLine($"\nYou now have ${money} in your account.\n");
}

void Deposit(int amountToAdd)
{
    money += amountToAdd;
    Console.WriteLine($"\nYou now have ${money} in your account.\n");
}