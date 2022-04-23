using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RabbitMQReiverCoreAPI.Models
{
    public partial class MedicineSystemContext : DbContext
    {
        public MedicineSystemContext()
        {
        }

        public MedicineSystemContext(DbContextOptions<MedicineSystemContext> options)
            : base(options)
        {
        }



        public DbSet<TblEmployee> TblEmployee { get; set; }

    }
}
