using IoT.DataContract.Request;
using IoT.DataContract.Response;
using IoT.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace IoT.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {

        private readonly ILogger<EventController> _logger;
        private readonly IEventService _EventService;

        public EventController(ILogger<EventController> logger, IEventService EventService)
        {
            _logger = logger;
            _EventService = EventService;
        }


        /// <summary>
        /// Get list of Events
        /// </summary>
        /// <param name="EventListOptions"></param>
        /// <param name="PagingParameters"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<Events?> GetAsync([FromQuery] EventListReq? EventListOptions, [FromQuery] DataContract.Request.Pagination? PagingParameters)
        {

            try
            {
                //get the list of events from the service based on the parameters
                return await _EventService.ListAsync(EventListOptions, PagingParameters);
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