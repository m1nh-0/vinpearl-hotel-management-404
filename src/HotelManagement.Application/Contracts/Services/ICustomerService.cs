﻿using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs;

namespace HotelManagement.Application.Contracts.Services
{
    public interface ICustomerService
    {
        Task<CustomerDTO> GetDetail(string id);
        Task<IList<CustomerDTO>> GetList();
        Task Add(CustomerDTO customer);
        Task Update(CustomerDTO customer);
    }
}