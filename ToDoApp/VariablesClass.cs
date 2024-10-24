namespace ToDoApp
{
    internal class VariablesClass
    {
        static string myName = "-250";

        public static decimal TestVariables()
        {
            //int myNumber = 10;

            //Console.WriteLine(myNumber + " " + myName);

            //if (myNumber == 10)
            //{
            //    Console.WriteLine("YES!!");
            //    Console.WriteLine(myName);

            //    myName = "Victor";
            //}

            int decResult = int.Parse(myName);

            //int parsed = int.Parse(myName);

            return decResult;
        }



        public static void TestVariables2()
        {
            string input = "  456  ";
            int result = int.Parse(input);
            Console.WriteLine(" " + result);
        }
    }
}
