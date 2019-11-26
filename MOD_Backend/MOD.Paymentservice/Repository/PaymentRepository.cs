using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Paymentservice.Context;
using MOD.Paymentservice.Models;

namespace MOD.Paymentservice.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentServiceContext _context;
        public PaymentRepository(PaymentServiceContext context)
        {
            try
            {
                _context = context;
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void Payment_Add(Payment item)
        {
            try
            {
                _context.Payments.Add(item);
                _context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public IEnumerable<Payment> GetAll()
        {
            try
            {
                return _context.Payments.ToList();
            }
            catch
            {
                throw;
            }
        }

        
    }
}
