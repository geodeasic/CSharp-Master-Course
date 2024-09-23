//Console.WriteLine("Hi. What would you like to do?\n");
//Console.WriteLine("[V]iew all TODO items.");
//Console.WriteLine("[A]dd a TODO item");
//Console.WriteLine("[D]elete a TODO item");
//Console.WriteLine("[Q]uit\n");

//Console.Write("Enter your choice: ");

//string userChoice = Console.ReadLine();

//if (userChoice == "V")
//{
//    Console.WriteLine("You selected: View all TODO items");
//}
//else if (userChoice == "A")
//{
//    Console.WriteLine("You selected: Add a TODO item");
//}
//else if (userChoice == "D")
//{
//    Console.WriteLine("You selected: Delete a TODO item");
//}
//else if (userChoice == "Q")
//{
//    Console.WriteLine("You selected: Quit ToDoApp");
//}

Console.WriteLine(AbsoluteSum(-20, 5));

Console.ReadLine();

int AbsoluteSum(int firstValue, int secondValue)
{
    int sum = firstValue + secondValue;

    if (sum < 0)
    {
        return -sum;
    }

    return sum;
}