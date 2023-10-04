namespace IoT.DataContract.Response
{
    /// <summary>
    /// Events list model
    /// </summary>
    public class Events
    {
        /// <summary>
        /// Event list
        /// </summary>
        public List<Event>? Items { get; set; }

        /// <summary>
        /// pagination Details
        /// </summary>
        public Pagination? PaginationDetails { get; set; }


    }
}
