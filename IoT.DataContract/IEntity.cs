namespace IoT.DataContract
{

    /// <summary>
    /// Common Entity properties
    /// </summary>
    public interface IEntity
    {

        /// <summary>
        /// Identifier
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Created On
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Last Updated On
        /// </summary>
        public DateTime UpdatedOn { get; set; }


        /// <summary>
        /// Is Deleted
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
