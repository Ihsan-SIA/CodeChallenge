class AddNumGame
{
        public static void EnterOk()
    {
        Console.WriteLine("Enter a number to add or ok to exit");
        string userInput = Console.ReadLine()!;
        double sum = 0;
        double number = 0;
        bool inputdoub = double.TryParse(userInput, out number);
        bool checkInput = false;

        do
        {
            switch (inputdoub)
            {
                case true:
                    sum += number;
                    Console.WriteLine("Enter a number to add or ok to exit");
                    userInput = Console.ReadLine()!;
                    inputdoub = double.TryParse(userInput, out number); break;
                case false:
                    switch (userInput.ToLower())
                    {
                        case "ok":
                            checkInput = true; break;
                        default:
                            Console.Write("You should've followed instructions, now enter ok or a number lil bro: ");
                            userInput = Console.ReadLine()!;
                            inputdoub = double.TryParse(userInput, out number); break;
                    }
                    break;
            }
        }
        while (!checkInput);
        Console.WriteLine("The total sum of numbers entered is {0}", sum);
    }
}