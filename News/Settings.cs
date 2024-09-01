using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    internal static class Settings
    {
       public static string NewsApiKey => "<Insert_Key>";

        public static async Task<string> GetNewsApiToken()
        {
            return await SecureStorage.Default.GetAsync("NewsApiKey");
            
        }

        public static async Task SaveToken(string apiKey)
        {
            if(string.IsNullOrEmpty(apiKey)) return;

            await SecureStorage.Default.SetAsync("NewsApiKey", apiKey);
        }
    }
}
