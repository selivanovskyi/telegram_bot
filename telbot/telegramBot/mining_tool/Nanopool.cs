using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telegramBot.mining_tool
{
    class NanopoolPrice
    {
        public bool Status { get; set; }
        public DataPriceNanopool data {get;set;}      
    }

    internal class DataPriceNanopool
    {
        public decimal price_usd { get; set; }
        public decimal price_eur { get; set; }
        public decimal price_rur { get; set; }
        public decimal price_CNY { get; set; }
        public decimal price_btc { get; set; }
    }

    class NanopoolMiner
    {
        public bool Status { get; set; }
        public NanopoolMinerData Data { get; set; }
    }

    class NanopoolMinerData
    {
        public string account { get; set; }
        public decimal unconfirmed_balance { get; set; }
        public decimal balance { get; set; }        
        public decimal hashrate { get; set; }
        public NanopoolMinerDataAvghashrate avghashrate { get; set; }
        public List<NanopoolMinerDataWorker> workers { get; set; }

    }
    class NanopoolMinerDataAvghashrate
    {
        public decimal h1 { get; set; }
        public decimal h3 { get; set; }
        public decimal h6 { get; set; }
        public decimal h12 { get; set; }
        public decimal h24 { get; set; }

    }
    class  NanopoolMinerDataWorker
    {
        public string id{ get; set; }
        public int uid { get; set; }
        public decimal hashrate { get; set; }
        public string lastShare { get; set; }
        public decimal rating { get; set; }
        public decimal h1 { get; set; }
        public decimal h3 { get; set; }
        public decimal h6 { get; set; }
        public decimal h12 { get; set; }
        public decimal h24 { get; set; }
    }

}
