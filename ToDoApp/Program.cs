//string IsNotEmptyString(string firstName)
//{
//    if (firstName == "James")
//    {
//        return "Correct";
//    }

//    return "Incorrect";
//}

int GetIntFromString(string input)
{
    int returnValue = int.Parse(input);

    return returnValue;
}

int result = GetIntFromString("20");

Console.WriteLine(result);


Console.ReadLine();

