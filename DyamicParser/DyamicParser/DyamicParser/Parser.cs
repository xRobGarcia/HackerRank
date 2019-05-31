using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DyamicParser
{
    class Parser: IParser
    {

        public dynamic Parse(string configuration)
        {
            var json = Regex.Replace(configuration, @"\ *?([^ ]*?)\ *?:\ *(.*?);", "\"$1\":\"$2\",");
            dynamic d = JObject.Parse("{" + json + "}");
            return d;
        }

    }

    internal interface IParser
    {
        dynamic Parse(string configuration);
    }
}
