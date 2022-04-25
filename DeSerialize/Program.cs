using System.Text.Json;
using Newtonsoft.Json;

namespace SerializeBasic
{

    public class datamodel
    {
        public string? key1 { get; set; }
        public string? key2 { get; set; }
        public string? key3 { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            StreamReader r = new StreamReader("file.json");
            string jsonString = r.ReadToEnd();
            datamodel? m = JsonConvert.DeserializeObject<datamodel>(jsonString);

        }
    }
}