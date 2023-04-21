using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    internal class Customer
    {
        private OrderForm orderform;
        private ProgressForm progform;
        private PromotionForm promoform;
        public Customer()
        {
            orderform = new OrderForm();
            orderform.Show(); 
        }
    }
}
