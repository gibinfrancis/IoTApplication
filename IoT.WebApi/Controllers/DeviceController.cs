using IoT.DataContract.Request;
using IoT.DataContract.Response;
using IoT.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace IoT.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {

        private readonly ILogger<DeviceController> _logger;
        private readonly IDeviceService _deviceService;

        public DeviceController(ILogger<DeviceController> logger, IDeviceService deviceService)
        {
            _logger = logger;
            _deviceService = deviceService;
        }


        /// <summary>
        /// Get list of Devices
        /// </summary>
        /// <param name="deviceListOptions"></param>
        /// <param name="PagingParameters"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Devices?> GetAsync([FromQuery] DeviceListReq? DeviceListOptions, [FromQuery] DataContract.Request.Pagination? PagingParameters)
        {

            try
            {
                //get the list of devies from the service based on the parameters
                return await _deviceService.ListAsync(DeviceListOptions, PagingParameters);
            }
            catch (Exception ex)
            {
                //Catch exceptions here
                _logger.LogError(ex, ex.Message);
            }

            return default;
        }
    }
}