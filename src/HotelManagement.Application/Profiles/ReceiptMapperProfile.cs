﻿using AutoMapper;
using HotelManagement.Application.DTOs.Receipt;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Domain;

namespace HotelManagement.Application.Profiles
{
    public class ReceiptMapperProfile : Profile
    {
        public ReceiptMapperProfile()
        {
            CreateMap<Receipt, ReceiptDTO>().ReverseMap();
            CreateMap<ReceiptDetail, ReceiptDetailDTO>();
            CreateMap<ReceiptDetailDTO, ReceiptDetail>()
                .ForMember(x => x.Customers, d => d.Ignore());
            CreateMap<ServiceReceipt, ServiceReceiptDTO>().ReverseMap();
        }
    }
}