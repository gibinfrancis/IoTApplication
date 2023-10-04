namespace IoT.DataContract
{
    /// <summary>
    /// Event model
    /// </summary>
    public class Event : IEntity
    {

        /// <summary>
        /// Identifier
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Device id
        /// </summary>
        public Guid DeviceId { get; set; }

        /// <summary>
        /// Event Identifier
        /// </summary>
        public long EventId { get; set; }

        /// <summary>
        /// Event Name
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// Event Value
        /// </summary>
        public dynamic EventValue { get; set; }

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
