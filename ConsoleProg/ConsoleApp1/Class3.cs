using System;
using ColorCnsl1;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;

namespace HomeWork1
{
    class GetHTML : IExecutionAction
    {
        private static string html = "Err";
        private static string otvet = "No";
        private static int i = 0;
        public string ExecutionAction()
        {
            do
            {
                ShowTags("https://www.yandex.ru/", "a", i);
                Thread.Sleep(1000);
                ColorCnsl.Write("{=Yellow}Next?{/}\n");
                otvet = Console.ReadLine();
                i++;
            }
            while (otvet != "No" && otvet != "NO" && otvet != "no");
            return "Press Enter";


        }
        private static async void ShowTags(string my_url, string tag, int i)
        {
            try
            {
                string data = await GetHtmlPageText(my_url);
                string pattern = string.Format(@"\<{0}.*?\>(?<tegData>.+?)\<\/{0}\>", tag.Trim());
                Regex regex = new Regex(pattern, RegexOptions.ExplicitCapture);
                MatchCollection matches = regex.Matches(data);
                Match matche = matches[i];
                Console.WriteLine(matche.Value);
            }
            catch
            {
                ColorCnsl.Write("{=Red}Error downloading from website {/}\n");
            }
        }
        private static async Task<string> GetHtmlPageText(string url)
        {
            await Task.Run(async () =>
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(url))
                using (HttpContent content = response.Content)
                {
                    string result = await content.ReadAsStringAsync();
                    if (html != null)
                    {
                        html = result;
                    }
                }
            });
            return html;
        }
    }
}