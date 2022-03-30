using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Mail
    {
        private int goldCost = 0;
        private int currencyGoldMax = 99999999;
        private int transmissionCurrencyValue = 0;
        private int transmissionCurrencyMax = 0;

        public Mail(int transmissionCurrencyValue, int transmissionCurrencyMax)
        {
            this.transmissionCurrencyValue = transmissionCurrencyValue;
            this.transmissionCurrencyMax = transmissionCurrencyMax;
        }
        public void IncreaseTransmissionCosts(int transmissionCnt)
        {
            transmissionCnt += 1;
            int transmissionGoldCost = 0;
            int tempPow = 0;

            for (int i = 1; i <= transmissionCnt; i++)
            {
                int tmp = (int)((Math.Pow(2f, i) - Math.Pow(2f, i - 1)));
                if (tmp * transmissionCurrencyValue > transmissionCurrencyMax)
                {
                    transmissionGoldCost = transmissionCurrencyMax;
                    break;
                }
                //++tempCnt;
                tempPow = (int)Math.Pow(2f, (i - 1));
                transmissionGoldCost = tmp * transmissionCurrencyValue;
            }
            if (transmissionGoldCost > currencyGoldMax)
                transmissionGoldCost = currencyGoldMax;

            Console.WriteLine(transmissionGoldCost.ToString("N0"));
        }
    }
}
