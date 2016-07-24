using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class DefaultDiscountHelper : IDiscountHelper
    {
        private decimal _discountSize;

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (_discountSize / 100m * totalParam));
        }

        public DefaultDiscountHelper(decimal discountSize)
        {
            this._discountSize = discountSize;
        }
    }
}