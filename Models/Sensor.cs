﻿namespace Model
{
    public abstract class Sensor
    {
        public abstract int[] getValues();
        public abstract int getValue();
        public abstract bool getBoolValue();
    }
}
