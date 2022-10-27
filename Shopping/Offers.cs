using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    public class Offers
    {
        public double Discount(List<Code> items)
        {
           double totalPrice = 0;
            
            double countA, countB, countC, countD, countE ;
            countA = countB = countC = countD = countE = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == Code.A)
                {
                    countA++;
                }
                if (items[i] == Code.B)
                {
                    countB++;
                }
                if (items[i] == Code.C)
                {
                    countC++;
                }
                if (items[i] == Code.D)
                {
                    countD++;
                }
                if (items[i] == Code.E)
                {
                    countE++;
                }
            }
            if (countA > 0)
            {
                totalPrice = 1.50 * countA;
            }
            
            if(countB > 0)
            {
                totalPrice += (int)(countB / 3) * 5 + (countB % 3) * 2;
            }

            if(countC > 0)
            {
                totalPrice += (int)(countC / 2) * 0.75 + (countC % 2) * 0.75;
            }
            
            if(countD > 0)
            {
                if(countD % 3 == 0)
                {
                    totalPrice += (int)(countD / 3) * 7 + (countD % 3) * 3;
                }
                else if(countD % 2 == 0)
                {
                    totalPrice += (int)(countD / 2) * 4.5 + (countD % 2) * 3;
                }
                else
                {
                    totalPrice += countD * 3;
                }
            }

            if(countE > 0)
            {
                if(countE % 3 == 0)
                {
                    totalPrice += ((int)(countE / 3) * 4.8 + (countE % 3) * 4.8);
                }
                else
                {
                    totalPrice += ((int)(countE / 3) * 4.8 + (countE % 3) * 4.8) / 2;
                }
                
            }

            if (items.Count >= 10)
            {
                totalPrice -= totalPrice * 0.1;
            }
            return totalPrice;
        }
    }
}

// GetTotal
