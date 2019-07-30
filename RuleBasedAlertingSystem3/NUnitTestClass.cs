using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlertingSystem;
using NUnit.Framework;

namespace RuleBasedAlertingSystem3
{
    [TestFixture]
    class NunitTestClass
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(5, AlertGenerator.CheckSpo2(101));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, AlertGenerator.CheckSpo2(100));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(1, AlertGenerator.CheckSpo2(97));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(1, AlertGenerator.CheckSpo2(95));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(2, AlertGenerator.CheckSpo2(93));
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(2, AlertGenerator.CheckSpo2(91));
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(3, AlertGenerator.CheckSpo2(90));
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual(3, AlertGenerator.CheckSpo2(80));
        }
        [Test]
        public void Test9()
        {
            Assert.AreEqual(3, AlertGenerator.CheckSpo2(77));
        }
        [Test]
        public void Test10()
        {
            Assert.AreEqual(4, AlertGenerator.CheckSpo2(60));
        }
        [Test]
        public void Test11()
        {
            Assert.AreEqual(4, AlertGenerator.CheckSpo2(0));
        }
        [Test]
        public void Test12()
        {
            Assert.AreEqual(5, AlertGenerator.CheckSpo2(-90));
        }

        [Test]
        public void Test13()
        {
            Assert.AreEqual(5, AlertGenerator.CheckPulseRate(221));
        }
        [Test]
        public void Test14()
        {
            Assert.AreEqual(4, AlertGenerator.CheckPulseRate(220));
        }
        [Test]
        public void Test15()
        {
            Assert.AreEqual(4, AlertGenerator.CheckPulseRate(170));
        }
        [Test]
        public void Test16()
        {
            Assert.AreEqual(4, AlertGenerator.CheckPulseRate(100));
        }
        [Test]
        public void Test17()
        {
            Assert.AreEqual(3, AlertGenerator.CheckPulseRate(80));
        }
        [Test]
        public void Test18()
        {
            Assert.AreEqual(3, AlertGenerator.CheckPulseRate(60));
        }
        [Test]
        public void Test19()
        {
            Assert.AreEqual(2, AlertGenerator.CheckPulseRate(50));
        }
        [Test]
        public void Test20()
        {
            Assert.AreEqual(2, AlertGenerator.CheckPulseRate(40));
        }
        [Test]
        public void Test21()
        {
            Assert.AreEqual(1, AlertGenerator.CheckPulseRate(30));
        }
        [Test]
        public void Test22()
        {
            Assert.AreEqual(1, AlertGenerator.CheckPulseRate(0));
        }
        [Test]
        public void Test23()
        {
            Assert.AreEqual(6, AlertGenerator.CheckPulseRate(-45));
        }


        [Test]
        public void Test24()
        {
            Assert.AreEqual(7, AlertGenerator.CheckTemperature(100));
        }
        [Test]
        public void Test25()
        {
            Assert.AreEqual(6, AlertGenerator.CheckTemperature(99));
        }
        [Test]
        public void Test26()
        {
            Assert.AreEqual(6, AlertGenerator.CheckTemperature(98.4));
        }
        [Test]
        public void Test27()
        {
            Assert.AreEqual(5, AlertGenerator.CheckTemperature(98));
        }
        [Test]
        public void Test28()
        {
            Assert.AreEqual(5, AlertGenerator.CheckTemperature(97));
        }
        [Test]
        public void Test29()
        {
            Assert.AreEqual(4, AlertGenerator.CheckTemperature(96));
        }
        [Test]
        public void Test30()
        {
            Assert.AreEqual(4, AlertGenerator.CheckTemperature(95.5));
        }
        [Test]
        public void Test31()
        {
            Assert.AreEqual(3, AlertGenerator.CheckTemperature(95));
        }
        [Test]
        public void Test32()
        {
            Assert.AreEqual(3, AlertGenerator.CheckTemperature(94));
        }
        [Test]
        public void Test33()
        {
            Assert.AreEqual(2, AlertGenerator.CheckTemperature(93));
        }
        [Test]
        public void Test34()
        {
            Assert.AreEqual(2, AlertGenerator.CheckTemperature(92));
        }
        [Test]
        public void Test35()
        {
            Assert.AreEqual(1, AlertGenerator.CheckTemperature(91));
        }
        [Test]
        public void Test36()
        {
            Assert.AreEqual(1, AlertGenerator.CheckTemperature(90));
        }
        [Test]
        public void Test37()
        {
            Assert.AreEqual(1, AlertGenerator.CheckTemperature(89));
        }
        [Test]
        public void Test38()
        {
            Assert.AreEqual(8, AlertGenerator.CheckTemperature(60));
        }
        [Test]
        public void Test39()
        {
            Assert.AreEqual(8, AlertGenerator.CheckTemperature(-63));
        }

        [Test]
        public void Test40()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            dir += @"BadPatientData.json";
            Assert.Throws(typeof(FileNotFoundException), delegate
            {
                Deserializer.DeserializeObjects<Patient>(
                    dir,"JSON");
            });
        }

        [Test]
        public void Test41()
        {
            Patient p =new Patient();
            p.PatientId = "JW3214";
            p.PulseRate = 72;
            p.Spo2 = 94;
            p.Temperature = 98.6;
            Assert.AreEqual(98.6,p.Temperature);
            Assert.AreEqual(94, p.Spo2);
            Assert.AreEqual(72, p.PulseRate);
            Assert.AreEqual("JW3214", p.PatientId);
        }
        [Test]
        public void Test43()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            dir += @"PatientData.json";
            var persons = Deserializer.DeserializeObjects<Patient>(dir,"JSON");
            var person = persons[0];
            //Console.WriteLine(person.PulseRate);
            Patient p= new Patient();
            p.PatientId = "TRJIW431";
            p.PulseRate = 75;
            p.Spo2 = 96;
            p.Temperature = 98.6;
            Assert.AreEqual(person.Temperature, p.Temperature);
            Assert.AreEqual(person.Spo2, p.Spo2);
            Assert.AreEqual(person.PulseRate, p.PulseRate);
            Assert.AreEqual(person.PatientId, p.PatientId);
        }
    }
}