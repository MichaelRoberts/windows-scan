using System.Collections;

namespace Computer.System.Detection.Hardware.Interfaces
{
    /// <summary>
    /// Used for the base of all hardware components. This struct requires that
    /// the minimum amount of information is the name of the hardware and the company
    /// or manufacturer that made it
    /// </summary>
    struct Component
    {
        /// <summary>
        /// The hardware components vendor or manufacturing company as specified by
        /// the registry key
        /// </summary>
        public string sManufacturer;
        
        /// <summary>
        /// The components name that is in the registry. This is the same name that
        /// is seen in the Windows Device Manager
        /// </summary>
        public string sComponentName;

        /// <summary>
        /// The component information that is not required to be filled. This can 
        /// contain any information about the hardware or even a null value.
        /// </summary>
        public ArrayList aComponentInformation;
    }
}
