using Newtonsoft.Json;
using System.IO;

namespace WAH.Common.Objects
{
    public class Config
    {
        public Config()
        {
        }

        public string FilePath { get; set; }
        public string URL { get; set; }
        public string ID { get; set; }
    }
}