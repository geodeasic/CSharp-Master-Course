﻿//string IsNotEmptyString(string firstName)
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

using ToDoApp;

string GetMyName()
{
    return "Vincent Okeyo";
}

int a = 4, b = 2, c = 15;
Console.WriteLine($"The first is {GetMyName()}, the second is {b}, and the third is {c}.");
Console.WriteLine("The first is {a}, the second is {b}, and the third is {c}.");

Console.WriteLine(VariablesClass.TestVariables());

Console.ReadLine();

