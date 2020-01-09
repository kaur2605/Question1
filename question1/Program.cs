using System;
using System.Collections.Generic;


namespace question1
{
    public class MakeChange
    {

        public static int Makechange(int money)

        {
            int[] denominations = new int[] { 100, 50, 20, 10, 5, 1 };
            int remained = money;
            int counter = 0;
            int index = 0;
            while(remained != 0)
            {
                if(remained >= denominations[index])
                {
                    counter++;
                    remained -= denominations[index];
                }
                else if( index <= 5)
                {
                    index++;
                }
                else
                {
                    return counter;
                }
            }
            return counter;
        }

        public static void Main(String[] args)
        {
            int money = 140;
            Makechange(money);
        }


    }
}


