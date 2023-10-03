namespace IoT.DataContract
{
    /// <summary>
    /// Device model
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Device id
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Device name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Device Description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Device type
        /// </summary>
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Device Status
        /// </summary>
        public DeviceStatus DeviceStatus { get; set; }

        /// <summary>
        /// Last Updated On
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Active Deployment Id
        /// </summary>
        public long ActiveDeploymentId { get; set; }

        /// <summary>
        /// Deployment Version
        /// </summary>
        public float DeploymentVersion { get; set; }

        /// <summary>
        /// Firmware Version
        /// </summary>
        public float FirmwareVersion { get; set; }


    }

    /// <summary>
    /// Device type
    /// </summary>
    public enum DeviceType
    {
        Unknown = 0,
        Device = 1,
        Gateway = 2,
    }


    /// <summary>
    /// Device status
    /// </summary>
    public enum DeviceStatus
    {
        Unknown = 0,
        Ready = 1,
        Active = 2,
        Desctive = 3,
        Stopped = 4,
        Error = 5,

    }
}
