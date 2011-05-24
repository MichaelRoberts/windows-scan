using Microsoft.Win32;
using Computer.Properties.Resources;
using Computer.System.Detection.Software.Interfaces;

namespace Computer.System.Detection.Software
{
    class MicrosoftOffice : ProductItem
    {
        private string Office2010Key;
        private string Office2010Id;
        private string Office2010Owner;
        private string Office2010Version;

        private Product Office2010;

        /// <summary>
        /// This Will Detect The Versions Of Office That Are Used By The User. It Will Retrieve The Serial Code
        /// And The Product Identification Number
        /// </summary>
        public MicrosoftOffice()
        {
            RegistryKey officehost = Registry.LocalMachine;
            RegistryKey officeInfo = officehost.OpenSubKey(RegistryStrings.MicrosoftOffice2010);

            Office2010Key = (string)officeInfo.GetValue(RegistryStrings.Office2010ProductId);
            Office2010Id = (string)officeInfo.GetValue(RegistryStrings.Office2010ProductKey);
            Office2010Owner = (string)officeInfo.GetValue(RegistryStrings.OfficeRegisteredTo);

            officeInfo = officehost.OpenSubKey(RegistryStrings.Office2010Version);
            Office2010Version = (string)officeInfo.GetValue(RegistryStrings.Office2010Build);

            // Make Key User Friendly Readable
            Office2010Key = Office2010Key.Insert(5, "-").Insert(11, "-").Insert(17, "-").Insert(23, "-");

            // Update the product information
            SetOfficeInformation();

            // Clean Up the memory
            CleanResources();

        }

        /// <summary>
        /// 
        /// </summary>
        private void SetOfficeInformation()
        {
            Office2010.ProductInformation   = null;
            Office2010.ProductIdentifier    = Office2010Id;
            Office2010.ProductSerial        = Office2010Key;
            Office2010.ProductRegister      = Office2010Owner;
            Office2010.ProductVersion       = Office2010Version;
            Office2010.ProductManufacturer  = ManufactuerStrings.Microsoft;
        }

        /// <summary>
        /// Get The Office 2010 Key That Is Found By This Class. This Will be The Highest Version Of The Office
        /// Product
        /// </summary>
        /// <returns>Office Key</returns>
        public string getOffice2010Key()
        {
            return Office2010Key;
        }

        /// <summary>
        /// Get The Product Id That Can Be Used To Get The Serial Number In Case This Program Does Not Find The
        /// Serial Number (Not Registered?)
        /// </summary>
        /// <returns>Product ID</returns>
        public string getOffice2010ProductId()
        {
            return Office2010Id;
        }

        /// <summary>
        /// 
        /// </summary>
        public override Product CurrentProduct
        {
            get
            {
                return Office2010;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return CurrentProduct.ProductName;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CleanResources()
        {
            Office2010Key = null;
            Office2010Id = null;
            Office2010Owner = null;
            Office2010Version = null;
        }
    }
}
