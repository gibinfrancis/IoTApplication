namespace IoT.DataContract.Request
{
    /// pagination parameters
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// Page Size
        /// </summary>
        public int PageSize { get; set; } = 50;

        /// <summary>
        /// Current Page Number
        /// </summary>
        public int PageNumber { get; set; } = 1;


    }
}
