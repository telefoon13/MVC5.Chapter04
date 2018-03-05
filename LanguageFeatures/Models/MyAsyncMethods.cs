using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();

            var httpTask = await client.GetAsync("http://apress.com");
            // we could do other things here while we are waiting
            // for the HTTP request to complete
            return httpTask.Content.Headers.ContentLength;
        }
    }
}