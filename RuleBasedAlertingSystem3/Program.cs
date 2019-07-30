using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlertingSystem;

namespace RuleBasedAlertingSystem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            //dir += @"PatientData.json";
            dir += @"PatientData.json";
            var persons = Deserializer.DeserializeObjects<Patient>(dir,"JSON").ToList();
            foreach (var person in persons)
            {
                Console.WriteLine("Patient {0} vitals:\n",person.PatientId);
                Console.WriteLine("Spo2:{0}\nPulseRate:{1}\nTemperature:{2}\n",
                    person.Spo2,person.PulseRate,person.Temperature);
                Console.WriteLine("Summary of patient {0}'s situation:\n", person.PatientId);
                AlertGenerator.CheckSpo2(person.Spo2);
                AlertGenerator.CheckPulseRate(person.PulseRate);
                AlertGenerator.CheckTemperature(person.Temperature);
            }

            Console.ReadLine();
        }
    }
}