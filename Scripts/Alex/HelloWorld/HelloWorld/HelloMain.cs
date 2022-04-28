using System; //using statement which allows you access to the System class
using WorkerClasses;

namespace HelloWorld //Namespace - in this case, the name of the program we created
{
    public class HelloMain //Main class that will run at the startup of your program
    {
        private static IWorkerClass worker;

        static HelloMain()
        {
            worker = new WorkerClass();
        }

        public HelloMain()
        {

        }

        public static void Main(string[] args)  //Main method.  All C# applications have to have a Main method.
        {
            HelloMain helloMain = new HelloMain();
            helloMain.RunMain();
        }

        public int RunMain()
        {
            worker = new WorkerClass();

            WorkerClass wc = new WorkerClass();

            wc.NameInfo = "My Name is Alex";
            wc.IdIndicator = 200;
            wc.IsWorkable = true;

            Console.WriteLine($"My Name is {wc.NameInfo}");
            Console.WriteLine($"My ID is {wc.IdIndicator}");
            Console.WriteLine($"Is Workable = {wc.IsWorkable}");
            Console.WriteLine();
            Console.WriteLine("Press Enter to clear the columns!");

            Console.ReadLine();

            worker.Clear(wc);

            Console.WriteLine($"Now, my Name is {wc.NameInfo}");
            Console.WriteLine($"And now, my ID is {wc.IdIndicator}");
            Console.WriteLine($"Finally, Is Workable = {wc.IsWorkable}");

            Console.WriteLine();
            Console.WriteLine("Press Enter to end the program...");
            Console.ReadLine();

            return 0;
        }

        internal bool TestHelloWorld()
        {
            return true;
        }
    }
}
