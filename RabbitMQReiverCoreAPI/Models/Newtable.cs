using System;
using System.Collections.Generic;

#nullable disable

namespace RabbitMQReiverCoreAPI.Models
{
    public partial class Newtable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string PostalZip { get; set; }
    }
}
