
// GetInteger()
public static int GetInteger()
        {
            string input = "";
            int output = 0;
            try
            {
                input = Console.ReadLine();
                output = int.Parse(input);
            }
            catch(FormatException)
            {
                Console.WriteLine("That was not a valid input.");                
            }
            return output;
        }

// GetInteger(int maxChoices)
public static int GetInteger(int maxChoices)
        {
            string input = "";
            int output = 0;
            try
            {
                input = Console.ReadLine();
                output = int.Parse(input);
                if (output > maxChoices|| output < 1 )
                {
                    throw new Exception("That number is out of range. Try again.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("That was not a valid input.");
                output = GetInteger(maxChoices);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                output = GetInteger(maxChoices);
            }
            return output;
        }
