using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace RuleBasedAlertingSystem3
{
    
    class Patient
    {
       
        public string PatientId { get; set; }

        
        public int Spo2 { get; set; }

        
        public int PulseRate { get; set; }

        
        public double Temperature { get; set; }

        


    }
}