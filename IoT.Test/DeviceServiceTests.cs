using IoT.DataContract.Response;
using IoT.Service.Implementation;

namespace IoT.Test
{
    public class DeviceServiceTests
    {



        /// <summary>
        /// Device service should list all devices no parameters are provided
        /// </summary>
        [Fact]
        public async Task DeviceService_ShouldListALldevices_WhenNoInputsProvided()
        {
            //Arrange
            DeviceService deviceService = new DeviceService();

            //Act
            Devices res = await deviceService.ListAsync(null);


            //Assert
            Assert.NotNull(res);
            Assert.NotNull(res.Items);
            Assert.NotNull(res.PaginationDetails);
            Assert.True(res.Items.Any());
        }
    }
}