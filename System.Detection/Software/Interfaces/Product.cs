using System.Collections;

namespace Computer.System.Detection.Software.Interfaces
{
    /// <summary>
    /// This Structure Is Used To Define A Single Product Or Application That Is Handled By This Program
    /// When Finding Serial Numbers, Product Identifiers And When Dealing With Application Specific 
    /// Information
    /// </summary>
    struct Product
    {
        /// <summary>
        /// This Represents The Current Product's Name. Not The Internal Name But The Publically Visible
        /// Application Name
        /// </summary>
        public string ProductName;

        /// <summary>
        /// This Is The Product Identifier That The Program Uses. This Is Not The Serial Number, It Is The
        /// Application Id That May Be Used In The Registry
        /// </summary>
        public string ProductIdentifier;

        /// <summary>
        /// This Is The Serial Number That The Application Was Registered Using. This Value Is Representing
        /// The Serial The Application Saved.
        /// </summary>
        public string ProductSerial;

        /// <summary>
        /// This Is The Manufacturer Of The Application. For Example Adobe Reader The Manufacturer Would Be
        /// Adobe Or Adobe Systems, Adobe Incorporated, Et Cetra.
        /// </summary>
        public string ProductManufacturer;

        /// <summary>
        /// The Name Of The Individual That Registered The Product. This May Not Be Found For Some Applications
        /// And Does Not Represent The Current User If It Is Registered To Someone Else
        /// </summary>
        public string ProductRegister;

        /// <summary>
        /// The Version Of The Product Or Application That Is Being Used By The Program. For Example Windows 7 
        /// Would Return 6.1.7600 As The Version Number
        /// </summary>
        public string ProductVersion;

        /// <summary>
        /// The Information Of The Application Or Program That Is Being Used By The Program. For Example The
        /// Internal Name Or Description Of The Application
        /// </summary>
        public ArrayList ProductInformation;
    }
}
