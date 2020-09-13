using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE245_LAB5_wamar
{
    class Customer : PersonV2
    {
        private DateTime customerSince;
        private double totalPurchases;
        private bool discountMember;
        private int rewardsEarned;


        public DateTime CustomerSince
        {
            get
            {
                return customerSince;
            }
            set
            {
                if (ValidationLibrary.IsAFutureDate(value) == false)
                {
                    customerSince = value;
                }
                else
                {
                    feedback += "\n ERROR : Enter a valid date";
                }
            }
        }

        public double TotalPurchases
        {
            get
            {
                return totalPurchases;
            }
            set
            {
                if (ValidationLibrary.IsMinimumAmount(value, 1) == true)
                {
                    totalPurchases = value;
                }
                else
                {
                    totalPurchases = 0;
                }
            }
        }

        public bool DiscountMember
        {
            get
            {
                return discountMember;
            }
            set
            {
                if (ValidationLibrary.IsItFilledInBool(value))
                {
                    discountMember = value;
                }
                else
                {
                    feedback += "\n ERROR : Enter true or false";
                }
            }
        }

        public int RewardsEarned
        {
            get
            {
                return rewardsEarned;
            }
            set
            {
                if (ValidationLibrary.IsMinimumAmount(value, 1) == true)
                {
                    rewardsEarned = value;
                }
                else
                {
                    rewardsEarned = 0;
                }
            }
        }

        public Customer() : base()
        {
            CustomerSince = DateTime.Now;
            TotalPurchases = 0;
            DiscountMember = false;
            RewardsEarned = 0;
        }
    }
}
