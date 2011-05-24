
namespace Computer.System.Scanner.Interfaces
{
    /// <summary>
    /// Class That Is The Base Of All The Scanner Modules Within This Program For Optimizing
    /// The registry
    /// </summary>
    abstract class BaseScanner
    {
        /// <summary>
        /// Allows For The Status Of The Scanner To be Updated To All Of The Components That
        /// Show The User Status Information
        /// </summary>
        public string CurrentStatusUpdate;

        /// <summary>
        /// Allows The Application To Get The Name Of The Scanner That Is Being Used To Scan
        /// The System
        /// </summary>
        abstract public string ScannerName
        {
            get;
        }

        /// <summary>
        /// Allows The Application To Get The Name Of The Scanner That Is Being Used To Scan
        /// The System
        /// </summary>
        /// <returns>Scanner Name</returns>
        public override string ToString()
        {
            return (string)ScannerName.Clone();
        }

        /// <summary>
        /// Get Or Set The Status Of The Scanner Being Used. This Will Be Used To Update The
        /// Status String On The Applications And On Dialogs
        /// </summary>
        abstract public string ScannerStatus
        {
            get;
            set;
        }
    }
}
