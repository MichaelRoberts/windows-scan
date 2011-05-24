
namespace Computer.System.Detection.Software.Interfaces
{
    /// <summary>
    /// This Class Will Contorl How All Of The Products Will Conduct The Information Gathering Within
    /// The Windows Enviroment
    /// </summary>
    abstract class ProductItem
    {
        /// <summary>
        /// Get And Set The Current Product Being Handled. This Will Represent All The Information About
        /// That Product As Well Using The Product Structure
        /// </summary>
        abstract public Product CurrentProduct
        {
            get;
        }

        /// <summary>
        /// Gets The String Representation Of The Product. This Will Contain All Of The Information About
        /// The Product In A Single String Format With Line Breaks
        /// </summary>
        /// <returns>Single String Product Information</returns>
        abstract public override string ToString();
    }
}
