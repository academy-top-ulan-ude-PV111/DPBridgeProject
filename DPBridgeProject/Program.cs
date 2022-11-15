namespace DPBridgeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logger logger;
            //ILoggerImpl logImpl = new SingleThreadImpl();

            //logger = new ConsoleLogger(logImpl);

            //logger.Log("Not error!!!");

            //logger.impl = new MultiThreadImpl();

            //logger.Log("Not error!!!");

            //logger = new SocketLogger(logImpl, "164:78:46:02", 2014);

            //logger.Log("Error in system");

            Programmer programmer;

            programmer = new FreelanceProgrammer(new CppLanguage());

            programmer.DoWork();
            programmer.Money();

            programmer = new CompanyProgrammer(new JavaLanguage());

            programmer.DoWork();
            programmer.Money();
        }
    }
}