using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_note
{
    internal static class Tools<T>
    {
        public static string serialize(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T deserialize(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static T read(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return deserialize(sr.ReadToEnd());
            }
        }

        public static void write(T obj, string path)
        {
            using (StreamWriter sr = new StreamWriter(path))
            {
                sr.Write(serialize(obj));
                sr.Flush();
            }
        }
    }
}
