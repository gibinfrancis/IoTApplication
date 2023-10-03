namespace IoT.DataContract.Request
{

    /// <summary>
    /// Device List Request
    /// </summary>
    public class DeviceListReq
    {
        /// <summary>
        /// Sort by column name
        /// </summary>
        public string SortBy { get; set; }

        /// <summary>
        /// is descending sort
        /// </summary>
        public bool IsDescSort { get; set; }

    }
}
