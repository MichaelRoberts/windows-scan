using System.Collections;

namespace Computer.System.Detection.Hardware.Interfaces
{
    /// <summary>
    /// The abstract class controlling the component interface for a hardware
    /// component
    /// </summary>
    abstract class HardwareItem
    {
        /// <summary>
        /// Get the component information of the specific hardware (name and vendor)
        /// using the interface Component
        /// </summary>
        abstract public Component HardwarePiece
        {
            get;
        }

        /// <summary>
        /// Get the componets tag so that additional information can be used when 
        /// the component information is being outputed
        /// </summary>
        abstract public ArrayList Tag
        {
            get;
        }

        /// <summary>
        /// Generates a string representation of the hardware component that is
        /// being specified
        /// </summary>
        /// <returns>String name of hardware component</returns>
        public abstract override string ToString();
    }
}
