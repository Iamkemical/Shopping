using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    public class Offers
    {
        public decimal Discount(List<Code> items) // ABBCC
        {
           decimal totalPrice = 0;
            
            decimal CountA, CountB, CountC, CountD, CountE ;
            CountA = CountB = CountC = CountD = CountE = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == Code.A)
                {
                    CountA++;
                }
                if (items[i] == Code.B)
                {
                    CountB++;
                }
                if (items[i] == Code.C)
                {
                    CountC++;
                }
                if (items[i] == Code.D)
                {
                    CountD++;
                }
                if (items[i] == Code.E)
                {
                    CountE++;
                }
            }


            if (CountA < 10)
            {
                totalPrice = 1.50 * CountA;

            }
            

            if (CountB >= 3)
            {
                if (CountB % 3 == 0)
                {
                    totalPrice = (CountB / 3) * 5;
                }
                else if (CountB % 3 != 0)
                {
                    totalPrice = (CountB % 3) * 5 + Math.Round(CountB / 3) * 2;
                }
                
            }
            else
            {
                totalPrice = CountB * 5;
            }


            if(CountC % 2 == 0)
            {

            }






            if (items.Count < 10)
            {
                totalPrice = (decimal)(1.50 * CountA);

            }
            else if (items.Count > 10)
            {
                decimal tenOff = (decimal)((1.50 * 10) * 0.1);
                totalPrice = (decimal)(1.50 * 10) - tenOff;

            }

            return 0;
        }
    }
}

// GetTotal
