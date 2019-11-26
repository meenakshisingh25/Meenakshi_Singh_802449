using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Paymentservice.Models;

namespace MOD.Paymentservice.Repository
{
   public interface IPaymentRepository
    {
        void Payment_Add(Payment item);
        IEnumerable<Payment> GetAll();
    }
}
