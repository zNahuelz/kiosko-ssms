using kiosko_ssms.Data;
using kiosko_ssms.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace kiosko_ssms.Services
{
    public class PaymentTypeService
    {
        private readonly AppDbContext dbContext;

        public PaymentTypeService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<PaymentType> GetAllPaymentTypes(bool showDeleted)
        {
            var paymentTypes = dbContext.PaymentTypes.Where(c => showDeleted || !c.IsDeleted).OrderBy(c => c.Name).ToList();
            return paymentTypes;
        }

    }
}
