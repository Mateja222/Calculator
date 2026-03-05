using System.ComponentModel.Design;

while (true)
{
    double num1;
    double num2;

    Console.WriteLine("._____________________________________________.");
    Console.WriteLine("|                                             |");
    Console.WriteLine("|-------------C A L C U L A T O R-------------|");
    Console.WriteLine("|_____________________________________________|");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");


    while (true)
    {
        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();


        if (string.IsNullOrWhiteSpace(input1))
        {
            Console.WriteLine("Input cannot be empty. Try again!");
            continue;
        }


        if (double.TryParse(input1, out num1))
        {
            break;
        }

        Console.WriteLine("Invalid input. Please enter a valid number.");
    }


    char operation;
    while (true)
    {
        Console.WriteLine("------ option-------- :");
        Console.WriteLine(" +  :  add");
        Console.WriteLine(" -  :  Subtract");
        Console.WriteLine(" *  :  Multiply");
        Console.WriteLine(" /  :  Divide");
        Console.Write("Enter an option : ");

        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input can't be empty... try again");
            continue;
        }
        operation = input[0];



        if (operation != '+' && operation != '-' && operation != '/' && operation != '*')
        {
            Console.WriteLine("Invalid Operation");
            continue;
        }

        break;
    }


    Console.WriteLine($"{num1}  {operation} __ ");





    while (true)
    {
        Console.Write("Enter first number: ");
        string input2 = Console.ReadLine();


        if (string.IsNullOrWhiteSpace(input2))
        {
            Console.WriteLine("Input cannot be empty. Try again!");
            continue;
        }


        if (double.TryParse(input2, out num2))
        {
            break;
        }

        Console.WriteLine("Invalid input. Please enter a valid number.");
    }









    switch (operation)
    {
        case '+':
            Console.Write(num1 + " + " + num2 + " = ");
            Console.WriteLine(num1 + num2);
            break;

        case '-':
            Console.Write(num1 + " - " + num2 + " = ");
            Console.WriteLine(num1 - num2);
            break;


        case '*':
            Console.Write(num1 + " * " + num2 + " = ");
            Console.WriteLine(num1 * num2);
            break;


        case '/':
            if (num2 == 0)
            {
                Console.WriteLine("Num2 can't be 0 in this operation");
                break;
            }
            Console.Write(num1 + " / " + num2 + " = ");
            Console.WriteLine(num1 / num2);
            break;

        default:
            Console.WriteLine("Los unos");
            break;
    }



    Console.WriteLine("Press any key to continue or q to exit");
    Console.Write("Input : ");
    string exit = Console.ReadLine();

    if (exit == "q")
    {
        break;
    }
    Console.Clear();










    Console.ReadKey();

}

