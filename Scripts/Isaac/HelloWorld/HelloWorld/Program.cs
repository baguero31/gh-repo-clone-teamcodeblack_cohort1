using System; //using statement which allows you access to the System class


namespace HelloWorld //Namespace - in this case, the name of the program we created
{
    internal class Program //Main class that will run at the startup of your program
    {
        static void Main(string[] args)  //Main method.  All C# applications have to have a Main method.
        {
        /*
         * These single lines represent individual C# STATEMENTS (write it down).
         * You can always tell the end of individual C# Statements because they will end with a
         * semicolon (;).
        */

            Console.WriteLine("Hello World!"); //Print a line to the black console screen.
        /*    Class.Method(Method Parameters); */

        /*  This second line calls the same class, but a different METHOD of that class  */
            Console.ReadLine();
            HelloWorld helloWorld = new HelloWorld();

            helloWorld.MyProperty = 34;
            helloWorld.newProp = "str";
        }
    }
    class HelloWorld
    {
        public int MyProperty { get; set; }
        public string newProp { get; set; }
    }


}
