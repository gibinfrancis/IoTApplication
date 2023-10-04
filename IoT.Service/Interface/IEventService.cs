using IoT.DataContract.Request;
using IoT.DataContract.Response;

namespace IoT.Service.Interface
{
    /// <summary>
    /// Interface for Event Service
    /// </summary>
    public interface IEventService
    {
        /// <summary>
        /// List all events of a device
        /// </summary>
        /// <param name="EventListReq"></param>
        /// <param name="pagingParameters"></param>
        /// <returns></returns>
        Task<Events> ListAsync(EventListReq? EventListReq, DataContract.Request.Pagination? pagingParameters);
    }
}
