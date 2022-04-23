using System;
using System.Collections.Generic;

#nullable disable

namespace RabbitMQReiverCoreAPI.Models
{
    public partial class TblEmployeeManager
    {
        public int EmpId { get; set; }
        public string EmployeeName { get; set; }
        public int? ManagerId { get; set; }
    }
}
