using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class LinqValueCalculator : ILinqValueCalculator
    {
        private IDiscountHelper _discountHelper;
        
        public LinqValueCalculator(IDiscountHelper discountHelper)
        {
            _discountHelper = discountHelper;
        }

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return _discountHelper.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}