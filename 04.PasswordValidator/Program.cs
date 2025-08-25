//Write a program that checks if a given password is valid.
//The password validation rules are:
//•	It should contain 6 – 10 characters (inclusive)
//•	It should contain only letters and digits
//•	It should contain at least 2 digits 
//If it is not valid, for any unfulfilled rule print the corresponding message:
//•	"Password must be between 6 and 10 characters"
//•	"Password must consist only of letters and digits"
//•	"Password must have at least 2 digits"



string password = Console.ReadLine();

if (IsValidLength(password) && IsValidContent(password) && IsValidCountDigits(password))
{
    Console.WriteLine("Password is valid");

}
else
{
    if (IsValidLength(password) == false)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
    if (IsValidContent(password) == false)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }
    if (IsValidCountDigits(password) == false)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }

}

    static bool IsValidLength(string? password)
    {
        if (password.Length >= 6 && password.Length <= 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

static bool IsValidContent(string password)
{
    foreach (char symbol in password)
    {
        if (char.IsLetterOrDigit(symbol) == false)
        {
            return false;
        }
    }

    return true;
}

static bool IsValidCountDigits (string password)
{
    int count = 0;

    foreach(char symbol in password)
    {
        if (char.IsDigit(symbol)) 
        {
            count++;
        }
    }
    return count >= 2;
}