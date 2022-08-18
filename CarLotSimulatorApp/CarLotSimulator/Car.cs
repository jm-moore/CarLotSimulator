using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        public Car()
        {

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public static string MakeEngineNoise(string EngineNoise)
        {
            return MakeEngineNoise(EngineNoise);
        }

        public static string MakeHonkNoise(string HonkNoise)
        {
            return MakeEngineNoise(HonkNoise);
        }
    }
}
