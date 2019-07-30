using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AlertingSystem
{
    class Deserializer
    {
        public static List<T> DeserializeObjects<T>(string filepath, string filetype)
        {
            if (filetype == "JSON")
            {
                List<T> list = new List<T>();
                try
                {
                    string patients = File.ReadAllText(filepath);

                    JsonSerializer serializer = new JsonSerializer();
                    using (var strreader = new StringReader(patients))
                    {
                        using (var jsonreader = new JsonTextReader(strreader))
                        {
                            //you should use this line
                            jsonreader.SupportMultipleContent = true;
                            while (jsonreader.Read())
                            {
                                list.Add(serializer.Deserialize<T>(jsonreader));
                            }

                        }
                    }


                }
                catch (Exception e)
                {
                    Type t = e.GetType();
                    Console.WriteLine("Invalid JSON format");
                    throw new FileNotFoundException();
                }

                return list;
            }
            else
            {
                throw new Exception("Please input data in JSON format");
            }
        }
    }
}
