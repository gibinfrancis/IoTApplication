﻿using IoT.DataContract.Request;
using IoT.DataContract.Response;

namespace IoT.Service.Interface
{
    /// <summary>
    /// Interface for Device Service
    /// </summary>
    public interface IDeviceService
    {
        /// <summary>
        /// List all devices
        /// </summary>
        /// <param name="deviceListOptions"></param>
        /// <param name="pagingParameters"></param>
        /// <returns></returns>
        Task<Devices> ListAsync(DeviceListReq? deviceListOptions, DataContract.Request.Pagination? pagingParameters);
    }
}
