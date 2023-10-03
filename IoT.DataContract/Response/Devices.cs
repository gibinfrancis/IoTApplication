namespace IoT.DataContract.Response
{
    /// <summary>
    /// Device list model
    /// </summary>
    public class Devices
    {
        /// <summary>
        /// Device list
        /// </summary>
        public List<Device>? Items { get; set; }

        /// <summary>
        /// pagination Details
        /// </summary>
        public Pagination? PaginationDetails { get; set; }


    }
}
