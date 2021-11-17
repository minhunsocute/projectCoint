using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Coins
    {

        public Coins(string currency,double buy_cash,double buy_transfer,double sell,string datetime) {
            this.currency = currency;
            this.buy_cash = buy_cash;
            this.buy_transfer = buy_transfer;
            this.sell = sell;
            this.date_time = datetime;
        }
        private string currency;
        private double buy_cash;
        private double buy_transfer;
        private double sell;
        private string date_time;
        public string Currency { get => currency; set => currency = value; }
        public double Buy_cash { get => buy_cash; set => buy_cash = value; }
        public double Buy_transfer { get => buy_transfer; set => buy_transfer = value; }
        public double Sell { get => sell; set => sell = value; }
        public string Date_time { get => date_time; set => date_time = value; }
    }
}
