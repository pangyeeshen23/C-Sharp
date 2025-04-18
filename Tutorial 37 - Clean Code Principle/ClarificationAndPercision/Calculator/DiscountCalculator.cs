using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClarificationAndPercision.Enum;

namespace ClarificationAndPercision.Calculator
{
    class DiscountCalculator
    {
        private const double DISCOUNT_THRESHOLD = 1000;
        // good example of DRY
        public double CalculateDiscount(CustomerTypeEnum type, double totalAmount)
        {
            double discount = 0;
            switch(type)
            {
                case CustomerTypeEnum.Regular:
                    discount = totalAmount > DISCOUNT_THRESHOLD ?  0.1 : 0.05;
                    break;
                case CustomerTypeEnum.Premium:
                    discount = totalAmount > DISCOUNT_THRESHOLD ? 0.1 : 0.05;
                    break;
            }
            return discount;
        }

        // bad example of DRY
        public double CalculateDiscountForRegular(double totalAmount)
        {
            double discount = 0;
            if (totalAmount > DISCOUNT_THRESHOLD)
            {
                discount = 0.1;
            }
            else
            {
                discount = 0.05;
            }
            return discount;
        }

        public double CalculateDiscountForPremium(double totalAmount)
        {
            double discount = 0;
            if (totalAmount > DISCOUNT_THRESHOLD)
            {
                discount = 0.1;
            }
            else
            {
                discount = 0.05;
            }
            return discount;
        }
    }
}
