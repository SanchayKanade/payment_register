using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;

namespace PaymentRegister.Models
{
    public class PaymentDetailContext : DbContext

    {   //Dependency injection required here for DbContextOptions which we will do via Program.cs
        public PaymentDetailContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PaymentDetail> PaymentDetails {get; set;}
    }
}
