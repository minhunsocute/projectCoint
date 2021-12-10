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
