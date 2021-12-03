﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Producer
{
    public class KY_024: Sensors
    {
        private int magnetic_field { get; set; }
        Random rnd=new Random();
        public KY_024()
        {

        }
        public int getValues()
        {
            return getMagneticField();
        }

        public int getMagneticField()
        {
            magnetic_field = rnd.Next(0, 1023);
            Console.WriteLine($"Magnetic field: {magnetic_field}");
            return magnetic_field;
        }
    }
}