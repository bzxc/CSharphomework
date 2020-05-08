using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Script {
    class SimpleCrawler {
        private Hashtable urls = new Hashtable ();
        private Queue urlQue = new Queue();
        private int count = 0;
        private int num = 10;
        static void Main (string[] args) {
            SimpleCrawler myCrawler = new SimpleCrawler ();
            string startUrl = "https://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urlQue.Enqueue(startUrl);
            myCrawler.urls.Add (startUrl, false); //加入初始页面
            Thread[] downloadThread;
            downloadThread = new Thread[21];
            for(int i=0; i < myCrawler.num; i++) {
                ThreadStart startDownload = new ThreadStart(myCrawler.Crawl);
                downloadThread[i] = new Thread(startDownload);
                downloadThread[i].Start();
            }
            //new Thread (myCrawler.Crawl).Start ();
        }

        private void Crawl () {
            Console.WriteLine ("开始爬行了.... ");
            while (true) {
                string current = null;
                /*
                foreach (string url in urls.Keys) {
                    if ((bool) urls[url]) continue;
                    else {current = url; break;}
                }
                */
                

                if (urlQue.Count == 0 || count > 20) break;

                current = (string)urlQue.Dequeue();
                Console.WriteLine ("爬行" + current + "页面!");
                string html = DownLoad (current); // 下载
                urls[current] = true;
                count++;
                Parse (html, current); //解析,并加入新的链接
                Console.WriteLine ("爬行结束");
            }
        }

        public string DownLoad (string url) {
            try {
                WebClient webClient = new WebClient ();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString (url);
                string fileName = count.ToString ();
                File.WriteAllText (fileName, html, Encoding.UTF8);
                return html;
            } catch (Exception ex) {
                Console.WriteLine (ex.Message);
                return "";
            }
        }

        private void Parse (string html, string urlNow) {
            string findhtml = @"<!DOCTYPE html>";
            Match matchHtml = new Regex(findhtml).Match(html);
            if(matchHtml == null) return;
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex (strRef).Matches (html);
            foreach (Match match in matches) {
                strRef = match.Value.Substring (match.Value.IndexOf ('=') + 1)
                    .Trim ('"', '\"', '#', '>');
                if(Char.IsLetter(strRef[0])&& strRef.Substring(0, 1)!="h" || strRef[0] == '/') {
                    strRef = urlNow + strRef;
                }
                else if(strRef.Substring(0,2) == "./") {
                    strRef = urlNow + strRef.Substring(2);
                }
                else if(strRef.Substring(0,2) == "..") {
                    if(urlNow.Substring(urlNow.Length-1) != "/") {
                        strRef = urlNow.Substring(0, urlNow.LastIndexOf("/")) + strRef.Substring(2);
                    }
                    else {
                        strRef = urlNow.Substring(0, urlNow.Substring(0, urlNow.Length-1).LastIndexOf("/")) + strRef.Substring(2);
                    }
                }


                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urlQue.Enqueue(strRef);//urls[strRef] = false;
            }
        }
    }
}