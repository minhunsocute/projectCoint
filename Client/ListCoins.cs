using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ListCoins
    {
        private static ListCoins _instance;
        public static ListCoins Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListCoins();
                return _instance;
            }
        }
        //5AUD*16083.38*16245.84*16755.43*11/17/2021 12:00:00 AM*|CAD*17568.91*17746.37*18303.03*11/17/2021 12:00:00 AM*|CHF*23736.82*23976.59*24728.66*11/17/2021 12:00:00 AM*|CNY*3471.84*3506.91*3617.46*11/17/2021 12:00:00 AM*|DKK*0*3384.78*3511.96*11/17/2021 12:00:00 AM*|EUR*24982.78*25235.13*26360.03*11/17/2021 12:00:00 AM*|GBP*29632.28*29931.6*30870.47*11/17/2021 12:00:00 AM*|HKD*2835.62*2864.26*2954.1*11/17/2021 12:00:00 AM*|INR*0*303.44*315.35*11/17/2021 12:00:00 AM*|JPY*191.33*193.26*203.4*11/17/2021 12:00:00 AM*|KRW*16.55*18.39*20.15*11/17/2021 12:00:00 AM*|KWD*0*74817.25*77754.52*11/17/2021 12:00:00 AM*|MYR*0*5372.92*5486.31*11/17/2021 12:00:00 AM*|NOK*0*2536.87*2642.75*11/17/2021 12:00:00 AM*|RUB*0*309.65*345.05*11/17/2021 12:00:00 AM*|SAR*0*6024.16*6260.66*11/17/2021 12:00:00 AM*|SEK*0*2494.25*2598.35*11/17/2021 12:00:00 AM*|SGD*16268.13*16432.46*16947.9*11/17/2021 12:00:00 AM*|THB*610.79*678.66*704.16*11/17/2021 12:00:00 AM*|USD*22520*22550*22750*11/17/2021 12:00:00 AM*|
        private ListCoins() { }
        public List<Coins> Load(string s) {
            List<Coins> result = new List<Coins>();
            int i = 1;
            while (i < s.Length) {
                string currency="";
                while (s[i] != '*') {
                    currency += s[i];i++;
                }i++;
                string buy_cash = "";
                while (s[i] != '*') {
                    buy_cash += s[i];i++;
                }i++;
                string buy_transfer = "";
                while (s[i] != '*') {
                    buy_transfer += s[i];i++;
                }i++;
                string sell = "";
                while (s[i] != '*') {
                    sell += s[i];i++;
                }i++;
                string date_time = "";
                while (s[i] != '*') {
                    date_time += s[i];i++;
                }i += 2;
                Coins c = new Coins(currency, double.Parse(buy_cash), double.Parse(buy_transfer), double.Parse(sell), date_time);
                result.Add(c);
            }
            return result;
        }
    }
}
