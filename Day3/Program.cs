namespace Day3
{
    class MyClass
    {
        private int id;
        private string name;

        public MyClass()
        {
            this.id = 1;
            this.name = "Rohit";
        }

        public MyClass(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        // method overloading
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }
    internal class Program
    {
        // Method //
        // default parameter //
        static void mymethod(string str = "sir")
        {
            Console.WriteLine("Hello" + str);

        }

        // named Arguments //
        static void namedarg(string firstname, string? middlename, string lastname)
        {
            Console.WriteLine("My name is " + firstname + " " + middlename + " " + lastname + " ");
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


            MyClass myclass = new MyClass();
            myclass.add(1, 2);
            myclass.add(2, 3, 4);

        }
    }
}