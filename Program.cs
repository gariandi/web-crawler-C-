using System;
using HtmlAgilityPack;

namespace Raspador
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           var web = new HtmlWeb();
           
           
           //var doc = web.Load("https://economia.uol.com.br/");
          
           //var dolar = doc.DocumentNode.SelectSingleNode("//section[1]/div[2]/div/div[1]/div[2]/h3/a[3]").InnerHtml;
           //var euro =  doc.DocumentNode.SelectSingleNode("//section[1]/div[2]/div/div[2]/div[2]/h3/a[3]").InnerHtml;  //com html no inicio n funfa, precisa tirar essa parte qdo cola
           //var btc = doc.DocumentNode.SelectSingleNode("//section[1]/div[2]/div/div[3]/table/tbody/tr[4]/td[3]").InnerHtml;


           //Console.WriteLine("dolar = ");
           //Console.WriteLine(dolar);
           //Console.WriteLine("euro = ");
           //Console.WriteLine(euro);
           //Console.WriteLine("btc = ");
           //Console.WriteLine(btc);
           //Console.WriteLine(DateTime.Now);

           
           var doc = web.Load("https://trends.google.com/trends/hottrends/visualize?pn=p18");                    
           //var doc = web.Load("https://trends.google.com/trends/hottrends/visualize?nrow=5&ncol=5&pn=p18");
           
           var palavras = doc.DocumentNode.SelectSingleNode("//*[@id='0-0']").InnerHtml;
           Console.WriteLine(palavras);
           
        }
    }
}