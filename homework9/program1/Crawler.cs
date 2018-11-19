using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections;
using System.IO;
using System.Diagnostics;

namespace program1
{
    public class Crawler
    {
        private Queue<string> urls = new Queue<string>();
        private int count = 0;
        public int Num = 5;
        private string html;
        private string current;
        private static object locker = new object();//作为锁

        public Crawler(string url)
        {
            if (url.Length > 0)
            {
                html = "";
                urls.Enqueue(url);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Crawler crawler = new Crawler("https://www.hao123.com/");//初始页面
                crawler.Craw();
                stopwatch.Stop();
                TimeSpan timeSpan = stopwatch.Elapsed;
                Console.WriteLine(timeSpan.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine("无法解析");
            }
        }

        public void Craw()
        {
            Console.WriteLine("Start crawing");
            while (true)
            {
                if (urls.Count == 0)
                {
                    break;
                }
                current = urls.Dequeue();
                html = current;
                if (current == null || count > 50)
                {
                    break;
                }
                Console.WriteLine("crawed " + current + " page!");
                DownLoad(current);
                Parse();//解析并加入新的链接
              
              
            }
            Console.WriteLine("Stop crawing");
        }

        private void Parse()
        {
                lock (locker)
                {
                    string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#(img)]+[""']";
                    MatchCollection matches = new Regex(strRef).Matches(html);
                    foreach (Match match in matches)
                    {
                        strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\\', '#', ' ', '>');
                        if (strRef.Length == 0)
                        { continue; }
                        Console.WriteLine(strRef);
                    if(urls.Count<=1000)
                        urls.Enqueue(strRef);
                    }
                }
            Thread[] downloadThread;//声名下载线程

            downloadThread = new Thread[21];//为线程申请资源，确定线程总数

            for (int i = 0; i < Num; i++)
            {
                if (urls.Count != 0)
                {
                    ThreadStart startDownload = new ThreadStart(() => DownLoad(urls.Dequeue()));

                    downloadThread[i] = new Thread(startDownload);//指定线程起始设置
                    downloadThread[i].Start();//逐个开启线程
                }
            }
        }

        public void DownLoad(string url)
        {
            try
            {
                lock (locker)
                {
                    WebClient webClient = new WebClient();
                    webClient.Encoding = Encoding.UTF8;
                    html = webClient.DownloadString(url);

                    string fileName = @"D:\crawler\" + count.ToString();
                    File.WriteAllText(fileName+".html",html, Encoding.UTF8);

                    count++;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                urls.Dequeue();
            }
        }
    }
}
