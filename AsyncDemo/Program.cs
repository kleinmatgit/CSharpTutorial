using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Task<string> t = GetTitle("https://app.pluralsight.com/library/courses/modeling-sci-fi-city-3ds-max-534/table-of-contents");
            string title = t.Result;
            Console.WriteLine(title);
            */

            Task<int> t1 = GetIntAsync();
            int i = t1.Result;
            Console.WriteLine($"returned result: {i}");

            Console.ReadLine();
        }

        // using async/await keyword (introduced with C# 5.0)
        static async Task<string> GetTitle(string url)
        {
            using (var w = new WebClient())
            {
                string content = await w.DownloadStringTaskAsync(url);
                return ExtractTitle(content);
            }
        }

        static async Task<int> GetIntAsync()
        {
            Random rd = new Random();
            int sec = rd.Next(1, 3);
            int x = rd.Next(0, 100);

            await Task.Delay(sec * 1000);
            return x;
        }

        // simulate async operation
        /*private static Task<int> GetInt(int sec, int x)
        {
            System.Threading.Thread.Sleep(sec * 1000);
            return (new Task<int>(() => x));
        }*/

        // using TPL async pattern (Task.ContinueWith..)
        static Task<string> GetTitleTplAsync(string url)
        {
            var w = new WebClient();
            Task<string> contentTask = w.DownloadStringTaskAsync(url);
            return contentTask.ContinueWith(t =>
            {
                string result = ExtractTitle(t.Result);
                w.Dispose();
                return result;
            });
        }

        // non async basic version
        static string GetTitleNonAsync(string url)
        {
            using (var w = new WebClient())
            {
                string content = w.DownloadString(url);
                return ExtractTitle(content);
            }
        }

        private static string ExtractTitle(string content)
        {
            const string TitleTag = "<title>";
            var comp = StringComparison.InvariantCultureIgnoreCase;
            int titleStart = content.IndexOf(TitleTag, comp);
            if (titleStart < 0)
            {
                return null;
            }
            int titleBodyStart = titleStart + TitleTag.Length;
            int titleBodyEnd = content.IndexOf("</title>", titleBodyStart, comp);
            return content.Substring(titleBodyStart, titleBodyEnd - titleBodyStart);
        }
    }
}
