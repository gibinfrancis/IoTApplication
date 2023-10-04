namespace IoT.DataContract.Request
{

    /// <summary>
    /// Event List Request
    /// </summary>
    public class EventListReq
    {

        /// <summary>
        /// Device id
        /// </summary>
        public Guid DeviceId { get; set; }

        /// <summary>
        /// Sort by column name
        /// </summary>
        public string? SortBy { get; set; }

        /// <summary>
        /// is descending sort
        /// </summary>
        public bool? IsDescSort { get; set; }

    }
}
