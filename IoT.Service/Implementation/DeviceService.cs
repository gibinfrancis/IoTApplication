using IoT.DataContract;
using IoT.DataContract.Request;
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
        /// <param name="deviceListOptions"></param>
        /// <param name="pagingParameters"></param>
        /// <returns></returns>
        public async Task<Devices> ListAsync(DeviceListReq? deviceListOptions, DataContract.Request.Pagination? pagingParameters)
        {
            await Task.Yield();
            Random random = new();
            List<Device> Items = new();
            pagingParameters ??= new DataContract.Request.Pagination();

            //generating dummy devices
            for (int i = 0; i < pagingParameters.PageSize; i++)
            {

                Items.Add(new Device()
                {
                    Id = i + 1,
                    DeviceId = Guid.NewGuid(),
                    Name = Utils.GenerateRandomString(6),
                    Description = Utils.GenerateRandomString(16),
                    DeviceType = Utils.GenerateRandomEnumValue<DeviceType>(),
                    DeviceStatus = Utils.GenerateRandomEnumValue<DeviceStatus>(),
                    UpdatedOn = Utils.GenerateRandomDate(),
                    CreatedOn = Utils.GenerateRandomDate(),
                    ActiveDeploymentId = random.Next(1, 100),
                    DeploymentVersion = (float)(random.NextDouble() * (5.0f - 1.0f) + 1.0f),
                    FirmwareVersion = (float)(random.NextDouble() * (5.0f - 1.0f) + 1.0f)
                }); ;
            }

            //return devices
            return new Devices()
            {
                Items = Items,
                PaginationDetails = new DataContract.Response.Pagination(100, pagingParameters.PageSize, pagingParameters.PageNumber)
            };

        }


    }
}