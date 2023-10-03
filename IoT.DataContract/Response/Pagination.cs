namespace IoT.DataContract.Response
{
    /// <summary>
    /// Pagination details
    /// </summary>
    public class Pagination
    {
        public Pagination(long? totalRecords, int pageSize, int pageNumber)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
            TotalRecords = totalRecords;
        }

        /// <summary>
        /// Page size
        /// </summary>
        public int PageSize { get; set; } = 50;
        /// <summary>
        /// Page number
        /// </summary>
        public int PageNumber { get; set; } = 1;
        /// <summary>
        /// Total number of records
        /// </summary>
        public long? TotalRecords { get; set; }
        /// <summary>
        /// Total number of pages
        /// </summary>
        public int? TotalPages => TotalRecords.HasValue ? (int)Math.Ceiling(TotalRecords.Value / (double)PageSize) : null;
        /// <summary>
        /// Has previous page
        /// </summary>
        public bool HasPrevious => PageNumber > 1;
        /// <summary>
        /// Has next page
        /// </summary>
        public bool HasNext => PageNumber < TotalPages;
    }
}