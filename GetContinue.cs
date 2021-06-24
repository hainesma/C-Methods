bool goOn = true;
while (goOn == true)
{
// [body of while loop]
goOn = GetContinue();
}

//
public static bool GetContinue()
{
    Console.WriteLine("Would you like to roll again? Y/N");
    string input = Console.ReadLine();
    if (input.Trim().ToLower() == "y")
    {
        return true;
    }
    else if (input.Trim().ToLower() == "n")
    {
        return false;
    }
    else
    {
        Console.WriteLine("I don't understand that input. Please try again.");
        return GetContinue();
    }
}
