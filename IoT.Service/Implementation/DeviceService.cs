using IoT.DataContract;
using IoT.DataContract.Response;
using IoT.Service.Interface;

namespace IoT.Service.Implementation
{

    /// <summary>
    /// Device service implementation
    /// </summary>
    public class DeviceService : IDeviceService
    {
        /// <summary>
        /// List all devices
        /// </summary>
        /// <param name="pagingParameters"></param>
        /// <returns></returns>
        public async Task<Devices> ListAsync(DataContract.Request.Pagination pagingParameters)
        {
            await Task.Yield();
            Random random = new Random();
            List<Device> Items = new();
            pagingParameters ??= new DataContract.Request.Pagination();

            //generating dummy devices
            for (int i = 0; i < pagingParameters.PageSize; i++)
            {

                Items.Add(new Device()
                {
                    Id = new Guid(),
                    DeviceId = "Device_" + random.Next(1000, 9999),
                    Name = GenerateRandomString(6),
                    Description = GenerateRandomString(16),
                    DeviceType = GenerateRandomEnumValue<DeviceType>(),
                    DeviceStatus = GenerateRandomEnumValue<DeviceStatus>(),
                    UpdatedOn = GenerateRandomDate(),
                    ActiveDeploymentId = random.Next(1, 100),
                    DeploymentVersion = (float)(random.NextDouble() * (5.0f - 1.0f) + 1.0f),
                    FirmwareVersion = (float)(random.NextDouble() * (5.0f - 1.0f) + 1.0f)
                });
            }

            //return devices
            return new Devices()
            {
                Items = Items,
                PaginationDetails = new Pagination(100, pagingParameters.PageSize, pagingParameters.PageNumber)
            };

        }



        /// <summary>
        /// Generate Random string
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
        /// <summary>
        /// Generate random Enum value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private static T GenerateRandomEnumValue<T>()
        {
            Array values = Enum.GetValues(typeof(T));
            Random random = new Random();
            return (T)values.GetValue(random.Next(values.Length));
        }

        /// <summary>
        /// Generate Random date
        /// </summary>
        /// <returns></returns>
        private static DateTime GenerateRandomDate()
        {
            Random random = new Random();
            DateTime startDate = new DateTime(2023, 5, 5);
            int range = (DateTime.Today - startDate).Days;
            return startDate.AddDays(random.Next(range));
        }
    }
}