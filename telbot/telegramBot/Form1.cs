using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Telegram.Bot;
using telegramBot.mining_tool;

namespace telegramBot
{
    public partial class Form1 : Form
    {
        TelegramBotClient bot = new TelegramBotClient("382577814:AAHhaLlGXyUJfVrOYwbVe3A5b2xzRUAMuGA");

        public Form1()
        {
            InitializeComponent();
        }

        public async void tn( string mes)
        {
            var chatId = "@silverCh"; //имя канала @ SilverTalkBot
            // информация о формате текста сообщения https://tlgrm.ru/docs/bots/api#formatting-options
            var bot = new TelegramBotClient("382577814:AAHMmUqL4n0wYdWDPFy9hh5jqfvUNXLKtms");//инициализация
           
            await bot.SetWebhookAsync("");



            var me = await bot.GetUpdatesAsync();

            var msg = await bot.SendTextMessageAsync(chatId, mes); // тип парсинга сообщения Markdown        
            //Bot.SetWebhook(""); // Обязательно! убираем старую привязку к вебхуку для бота
            int offset = 0; // отступ по сообщениям

           

              
            


        }

        private void testMsg_Click(object sender, EventArgs e)
        {

            tn("tst");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Telegrammes.getCurency();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            Telegrammes.initTel();

        }
        bool fl = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (fl)
            {                
                timer1.Enabled = true;
                fl = !fl;
            }
            else
            {
                timer1.Enabled = false;
                fl = !fl;
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {


            //NanopoolMinerDataWorker w = JObject.Parse("{\n                \"id\": \"570t\",\n                \"uid\": 93986,\n                \"hashrate\": \"1890.0\",\n                \"lastshare\": 1514071107,\n                \"rating\": 6280,\n                \"h1\": \"1155.0\",\n                \"h3\": \"1260.0\",\n                \"h6\": \"1254.2\",\n                \"h12\": \"1271.7\",\n                \"h24\": \"1338.8\"\n            }").ToObject<NanopoolMinerDataWorker>();
            NanopoolMiner m = NanopoolExplorer.ETNNanopoolMiner("etnjzKFU6ogESSKRZZbdqraPdcKVxEC17Cm1Xvbyy76PARQMmgrgceH4krAH6xmjKwJ3HtSAKuyFm1BBWYqtchtq9tBap8Qr4M.3372294e90bbf9e0159556d0058c528b19d179906fdce413357dd4905caee9b7").Result;

            //tn("btc_etn: " + m.data.price_btc.ToString() + "\r\n " + "usd_etn: " + m.data.price_usd);
            // tn();

        }
    }
}
