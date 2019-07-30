using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleBasedAlertingSystem3
{
    class AlertGenerator
    {
        public enum Spo2Level
        {
            NormalHealthy=1,
            ClinicallyAcceptable= 2,
            Hypoxemia = 3,
            LackOfO2 = 4,
            InvalidInput = 5
        }
        public enum Pulse
        {
            BelowHealthy = 1,
            Sleeping = 2,
            HealthyResting = 3,
            Excercise = 4,
            VeryHigh = 5,
            InvalidInput=6
        }
        public enum Temp
        {
            Emergency = 1,
            Sleepy = 2,
            Loss = 3,
            Hypothermia = 4,
            Cold = 5,
            Normal = 6,
            Fever = 7,
           InvalidInput=8
        }
        public static Spo2Level CheckSpo2(int s)
        {

            if (s >= 95 && s <= 100)
            {
                Console.WriteLine(" Normal healthy individual");
                return Spo2Level.NormalHealthy;
            }
            else if (s >= 91 && s < 95)
            {
                Console.WriteLine(" Clinically acceptable but low. Patient may be a smoker or be unhealthy");
                return Spo2Level.ClinicallyAcceptable;
            }
            else if (s >= 70 && s <= 90)
            {
                Console.WriteLine(" Hypoxemia. Unhealthy and unsafe level");
                return Spo2Level.Hypoxemia;
            }
            else if (s >= 0 && s < 70)
            {
                Console.WriteLine(" Extreme lack of oxygen, ischemic disease may occur");
                return Spo2Level.LackOfO2;
            }
            else
            {
                Console.WriteLine("Invalid input");
                return Spo2Level.InvalidInput;
            }
        }
        public static Pulse CheckPulseRate(int p)
        {

            if (p >= 0 && p < 40)
            {
                Console.WriteLine(" Below healthy resting heart rate");
                return Pulse.BelowHealthy ;
            }
            else if (p >= 40 && p < 60)
            {
                Console.WriteLine(" Resting heartrate for sleeping");
                return Pulse.Sleeping;
            }
            else if (p >= 60 && p < 100)
            {
                Console.WriteLine(" Healthy adult resting heart rate");
                return Pulse.HealthyResting;
            }
            else if (p >= 100 && p <= 220)
            {
                Console.WriteLine(" Acceptable if measured during exercise. Not acceptable if resting heart rate");
                return Pulse.Excercise;
            }
            else if (p > 220)
            {
                Console.WriteLine(" Abnormally high heart rate");
                return Pulse.VeryHigh;
            }

            return Pulse.InvalidInput;
        }
        public static Temp CheckTemperature(double t)
        {

            if (t >= 89 && t <= 91)
            {
                Console.WriteLine(" Medical Emergency\n");
                return Temp.Emergency;
            }
            else if (t > 91 && t <= 93)
            {
                Console.WriteLine(" Sleepiness, Depressed, Confused\n");
                return Temp.Sleepy;
            }
            else if (t > 93 && t <= 95)
            {
                Console.WriteLine(" Loss of moment of fingers, blueness and confusion\n");
                return Temp.Loss;
            }
            else if (t > 95 && t <= 96)
            {
                Console.WriteLine(" Hypothermia\n");
                return Temp.Hypothermia;
            }
            else if (t > 96 && t <= 98)
            {
                Console.WriteLine(" Feeling cold\n");
                return Temp.Cold;
            }
            else if (t > 98 && t <= 99)
            {
                Console.WriteLine(" Normal body temperature\n");
                return Temp.Normal;
            }
            else if (t > 99)
            {
                Console.WriteLine(" Unhealthy and high fever\n");
                return Temp.Fever;
            }
            else
            {
                Console.WriteLine(" Invalid input\n");
                return Temp.InvalidInput;
            }

          
        }
    }
}
