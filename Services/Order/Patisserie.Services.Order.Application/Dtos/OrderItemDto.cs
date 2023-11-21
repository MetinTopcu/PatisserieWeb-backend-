using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patisserie.Services.Order.Application.Dtos
{
    public class OrderItemDto
    {
        public string ProductId { get;  set; }

        public string ProductName { get;  set; }

        public string PictureUrl { get;  set; }

        public Decimal Price { get;  set; }
        public int Quantity { get;  set; }
    }
}
