using Computer.System.Detection.Hardware.Interfaces;
using Microsoft.Win32;
using Computer.Properties.Resources;
using System.Collections;

namespace Computer.System.Detection.Hardware
{
    /// <summary>
    /// Gathers information about the processor currently running on the windows
    /// computer based off of information found in the registry
    /// </summary>
    class Processor : HardwareItem
    {
        private Component cProcessorInformation;
        private string sProcessorName;
        private string sProcessorVendor;

        /// <summary>
        /// Gets the processor component information that is found inside of the
        /// registry
        /// </summary>
        public override Component HardwarePiece
        {
            get 
            {
                return cProcessorInformation;
            }
        }

        /// <summary>
        /// Contains all of the information that was found on the component. this 
        /// information is used to supplement all the information other than the
        /// manufacturer and the hardware name
        /// </summary>
        public override ArrayList Tag
        {
            get 
            {
                return HardwarePiece.aComponentInformation;
            }
        }

        /// <summary>
        /// Give the processor name as the string return value. This will be the 
        /// same name available in the device manager
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return HardwarePiece.sComponentName;
        }

        /// <summary>
        /// Gather and setup the information about the processor component based
        /// on the registry values
        /// </summary>
        public Processor()
        {
            // Open the keys to gather the information
            RegistryKey componentKey = Registry.LocalMachine;
            RegistryKey processor = componentKey.OpenSubKey(RegistryStrings.ProcessorRegistryBase);

            sProcessorName = (string)processor.GetValue(RegistryStrings.ProcessorNameKey);
            sProcessorVendor = (string)processor.GetValue(RegistryStrings.ProcessorVendorKey);
            
            // Clean up the memory by releasing the keys
            componentKey = null;
            processor = null;

            // Call a method to finalize the information
            FinalizeInformation();
        }

        /// <summary>
        /// Deconstructor of the class so that resources can be freed up in memory 
        /// to allow more efficent execution of code
        /// </summary>
        ~Processor()
        {
            
        }

        /// <summary>
        /// Finializes all of the components information so that the component
        /// information can be called by the main program
        /// </summary>
        private void FinalizeInformation()
        {
            cProcessorInformation.sComponentName = sProcessorName;
            cProcessorInformation.sManufacturer = sProcessorVendor;
            cProcessorInformation.aComponentInformation = null;
        }
    }
}
