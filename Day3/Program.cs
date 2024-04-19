namespace Day3
{
    class MyClass
    {
        private int id, name;

        public MyClass ()
        {
            
        }
    }
    internal class Program
    {
        // Method //
        // default parameter //
        static void mymethod(string str="sir")
        {
            Console.WriteLine("Hello"+str);
     
        }

        // named Arguments //
        static void namedarg(string firstname, string? middlename, string lastname)
        {
            Console.WriteLine("My name is "+ firstname +" "+ middlename + " " + lastname + " ");
        }


        static void Main(string[] args)
        {

            // string //
            /*string firstname = "Rohit";
            string Lastname = "Pagar";
            string name = $"My name is {firstname} {Lastname}";
            Console.WriteLine(name);

            Console.WriteLine(name.Substring(5));*/


            //  Array  //
            /*int[,] arr = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }*/


            /*mymethod();

            mymethod("Rohit");*/

            /*namedarg(lastname: "Pagar", firstname: "Rohit", middlename: "Himmatrao");
            
            string firstname=Console.ReadLine();
            string middlename =Console.ReadLine();
            string lastname=Console.ReadLine();
            namedarg(lastname: "Pagar", firstname: "Srushti", middlename: "");
            namedarg(lastname: "Pagar", firstname: "Rohit", middlename: "Himmatrao");
            namedarg(lastname: lastname, firstname: firstname, middlename: middlename);*/


            // method overloading //
            
        }
    }
}