using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDListDemo
{
    public class Startup
    {
        public async IAsyncEnumerable<IMS> GetFiles()
        {
            foreach (var item in await GetFile())
            {
                yield return item;
            }
        }

        private async Task<IEnumerable<IMS>> GetFile()
        {
            IEnumerable<IMS> resultList = default(IEnumerable<IMS>);
            string filePath = @"C:\\dms.json";
            if (System.IO.File.Exists(filePath))
            {
                resultList = JsonConvert.DeserializeObject<IEnumerable<IMS>>(System.IO.File.ReadAllText(filePath));
            }
            var tempItem = from item in resultList
                           where item.Members.Contains("UPKNWUP1B")
                           select item;
            return resultList.Where(item => item.Members.Contains("USLACKBOT"));
        }
    }
}
