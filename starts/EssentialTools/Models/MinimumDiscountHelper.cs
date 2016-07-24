using System;
namespace EssentialTools.Models
{
    public class MinimumDiscountHelper : IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            if (totalParam > 100m)
                return totalParam * 0.9M;
            else if (totalParam >= 10m)
                return totalParam - 5m;
            else if (totalParam >= 0m)
                return totalParam;

            throw new ArgumentOutOfRangeException();
        }
    }
}