using System;
namespace RobotPrototype
{
    class Program
    {
        static void Main(string[] args)
        { 
         
            IndustrialRobot industrialRobot = new IndustrialRobot(
                "IR-200",
                24,
                "v2.0",
                "Welding"
            );

      
            EntertainmentRobot entertainmentRobot = new EntertainmentRobot(
                "ER-300",
                10,
                "v1.5",
                "Dancing and interacting with visitors"
            );
            
            ServiceRobot serviceRobot = new ServiceRobot(
                "SR-100",
                12,
                "v1.0",
                "Assisting customers"
            );

            
            RobotFactory factory = new RobotFactory();

            
            factory.RegisterPrototype("Service", serviceRobot);
            factory.RegisterPrototype("Industrial", industrialRobot);
            factory.RegisterPrototype("Entertainment", entertainmentRobot);

           
            Console.WriteLine("========================================");
            Console.WriteLine("          ORIGINAL ROBOTS");
            Console.WriteLine("========================================");
            Console.WriteLine();

            serviceRobot.Display();
            industrialRobot.Display();
            entertainmentRobot.Display();

           
            ServiceRobot clonedServiceRobot =
                (ServiceRobot)factory.CreateRobot("Service");

            clonedServiceRobot.BatteryCapacity = 18;
            clonedServiceRobot.SoftwareVersion = "v1.1";

            
            IndustrialRobot clonedIndustrialRobot =
                (IndustrialRobot)factory.CreateRobot("Industrial");

            clonedIndustrialRobot.BatteryCapacity = 30;
            clonedIndustrialRobot.SoftwareVersion = "v2.1";

           
            EntertainmentRobot clonedEntertainmentRobot =
                (EntertainmentRobot)factory.CreateRobot("Entertainment");

            clonedEntertainmentRobot.BatteryCapacity = 15;
            clonedEntertainmentRobot.SoftwareVersion = "v1.6";

            
            Console.WriteLine("========================================");
            Console.WriteLine("    CLONED AND CUSTOMIZED ROBOTS");
            Console.WriteLine("========================================");
            Console.WriteLine();

            clonedServiceRobot.Display();
            clonedIndustrialRobot.Display();
            clonedEntertainmentRobot.Display();

            
            Console.WriteLine("========================================");
            Console.WriteLine("          CLONE TEST");
            Console.WriteLine("========================================");

            Console.WriteLine(
                "Original Service Robot Software: "
                + serviceRobot.SoftwareVersion
            );

            Console.WriteLine(
                "Cloned Service Robot Software: "
                + clonedServiceRobot.SoftwareVersion
            );

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}