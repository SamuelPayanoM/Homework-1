// See https://aka.ms/new-console-template for more information
bool active = true;


// un programa que le pida si es par o impar
while (active)
{
    Console.WriteLine("Do you want to check number: ");
    Console.WriteLine("1. Check Number");
    Console.WriteLine("2. Exit");

    bool input = int.TryParse(Console.ReadLine(), out int number);

    switch (number)
    {
        case 1:
            {
                Console.Clear();
                Console.WriteLine("Write your number: ");
                bool inputNumber = int.TryParse(Console.ReadLine(), out int checkNumber);
                string message = checkNumber % 2 == 0 ? "Par" : "Impar";
                Console.WriteLine($"number result: {checkNumber} = {message}");
                Console.ReadKey();
            }
            break;
        case 2:
            {
                Console.WriteLine("Do you want to exit of program: ");
                active = false;
            }
            break;
        default:
            {
                Console.WriteLine("You option select is incorrect");
                Console.WriteLine("y/n");
                active = Console.ReadLine()!.ToLower() == "y" ? false : true;

            }
            break;
    }

}