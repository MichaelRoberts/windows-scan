using System;
using Computer.System.Detection.Hardware.Interfaces;
using Computer.System.Detection.Hardware;
using Computer.System.Detection.Software.Interfaces;
using Computer.System.Detection.Software;
using System.Threading;

namespace Computer_Information.System
{
    class EntryPoint
    {
        static HardwareItem hi_hardware;
        static ProductItem pi_software;

        public static void Main()
        {
            hi_hardware = new Processor();
            PrintHardware(hi_hardware.HardwarePiece);

            pi_software = new MicrosoftOffice();
            PrintSoftware(pi_software.CurrentProduct);

            Console.ReadKey();
        }

        private static void PrintSoftware(Product pi_software)
        {
            Console.WriteLine(pi_software.ProductName);
            Console.WriteLine(pi_software.ProductSerial);
            Console.WriteLine(pi_software.ProductVersion);
            Console.WriteLine(pi_software.ProductManufacturer);
            Console.WriteLine(pi_software.ProductRegister);
            Console.WriteLine(pi_software.ProductIdentifier);
        }

        private static void PrintHardware(Component hi_hardware)
        {
            Console.WriteLine(hi_hardware.sComponentName);
            Console.WriteLine(hi_hardware.sManufacturer);
        }
    }
}
