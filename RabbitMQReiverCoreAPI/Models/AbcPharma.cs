using System;
using System.Collections.Generic;

#nullable disable

namespace RabbitMQReiverCoreAPI.Models
{
    public partial class AbcPharma
    {
        public int Id { get; set; }
        public string MedicineName { get; set; }
        public string Brand { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantiy { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Notes { get; set; }
    }
}
