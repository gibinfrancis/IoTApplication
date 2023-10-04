using IoT.DataContract;
using IoT.DataContract.Request;
using IoT.DataContract.Response;
using IoT.Service.Interface;

namespace IoT.Service.Implementation
{

    /// <summary>
    /// Event service implementation
    /// </summary>
    public class EventService : IEventService
    {
        /// <summary>
        /// List all events of a device
        /// </summary>
        /// <param name="EventListReq"></param>
        /// <param name="pagingParameters"></param>
        /// <returns></returns>
        public async Task<Events> ListAsync(EventListReq? EventListReq, DataContract.Request.Pagination? pagingParameters)
        {
            await Task.Yield();
            Random random = new();
            List<Event> Items = new();
            pagingParameters ??= new DataContract.Request.Pagination();

            //generating dummy Events
            for (int i = 0; i < pagingParameters.PageSize; i++)
            {
                Items.Add(new Event()
                {
                    Id = i + 1,
                    DeviceId = EventListReq.DeviceId,
                    EventId = (EventListReq.EventId != 0 ? EventListReq.EventId : random.Next(1, 100)),
                    EventName = Utils.GenerateRandomString(5),
                    EventValue = random.Next(1, 100),
                    UpdatedOn = Utils.GenerateRandomDate(),
                    CreatedOn = Utils.GenerateRandomDate()
                }); ;
            }

            //return events
            return new Events()
            {
                Items = Items,
                PaginationDetails = new DataContract.Response.Pagination(100, pagingParameters.PageSize, pagingParameters.PageNumber)
            };

        }

    }
}