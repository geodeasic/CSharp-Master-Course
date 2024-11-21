//string IsNotEmptyString(string firstName)
//{
//    if (firstName == "James")
//    {
//        return "Correct";
//    }

//    return "Incorrect";
//}

//int GetIntFromString(string input)
//{
//    int returnValue = int.Parse(input);

//    return returnValue;
//}

//int result = GetIntFromString("20");

//Console.WriteLine(result);

//using ToDoApp;

//string GetMyName()
//{
//    return "Vincent Okeyo";
//}

//int a = 4, b = 2, c = 15;
//Console.WriteLine($"The first is {GetMyName()}, the second is {b}, and the third is {c}.");
//Console.WriteLine("The first is {a}, the second is {b}, and the third is {c}.");

//Console.WriteLine(VariablesClass.TestVariables());

string WhichName(string userInput)
{
    //if (userInput == "Vincent")
    //{
    //    return "That is your first name";
    //}
    //else if (userInput == "Okeyo")
    //{
    //    return "That is your last name";
    //}
    //else
    //{
    //    return "That is not your name";
    //}

    return userInput switch
    {
        "Vincent" => "That is your first name",
        "Okeyo" => "That is your last name",
        _ => "That is not your name",
    };
})

Console.ReadLine();

