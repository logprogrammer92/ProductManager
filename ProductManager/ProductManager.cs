namespace ProductManager
{
    /// <summary>
    /// Represents a product for sale
    /// </summary>
    public class ProductManager
    {
        public ProductManager()
        {
        }

        // Constructor to force name to be passed in
        // when creating the object
        //public ProductManager(string productName) 
        //{
        //    Name = productName;
        //}
        /// <summary>
        /// A unique identifier for the product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The user facing name of the product
        /// </summary>
        public string Name { get; set; }



        #region
        // Fully implemented C# property
        //private int _id;

        //public int ProductId
        //{
        //    get
        //    {
        //        return _id;
        //    } 
        //    set
        //    {
        //        _id = value;
        //    }
        //}
        #endregion
    }
}
