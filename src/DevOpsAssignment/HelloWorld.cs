namespace DevOpsAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {

            OutputString os = new OutputString(@"c:\temp\HelloWorld.txt");
            System.Console.WriteLine(StringHelper.HelloWorldString());
            os.Save(StringHelper.HelloWorldString());
            System.Console.ReadLine();
        }
    }
}
