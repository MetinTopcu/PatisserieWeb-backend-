﻿using MediatR;
using Patisserie.Services.Order.Application.Dtos;
using Patisserie.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patisserie.Services.Order.Application.Command
{
    public class CreateOrderCommand : IRequest<Response<CreatedOrderDto>>
    {

        public string BuyerId { get; set; }

        public List<OrderItemDto> OrderItems { get; set; }

        public AddressDto Address { get; set; }



    }
}
