﻿namespace RabbitMQ.Producer
{
    public class _6MV2: Sensors
    {
        private int x { get; set; }
        private int y { get; set; }
        private Random rnd = new Random();

        public _6MV2()
        {

        }

        public int[] getValues()
        {
            return getCoordinates();
        }
        public int[] getCoordinates()
        {
            int[] coordinates = new int[2];
            x = rnd.Next(0, 100);
            y = rnd.Next(0, 100);
            coordinates[0] = x;
            coordinates[1] = y;
            Console.WriteLine($"Coordinates: {x}, {y} ");
            return coordinates;
        }
    }
}