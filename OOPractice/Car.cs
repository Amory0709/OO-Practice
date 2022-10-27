namespace OOPractice
{
    using System;
    public class Car
    {
        private string name;
        private string speed;
        public Car(string name, string speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
            return this.name + ": speed up " + this.speed + "km/h";
        }
    }
}
