namespace Racer.Models
{
    public abstract class Car
    {      
        public string Model { get; set; }
        public double Speed { get; set; }
        //public Car(string model, int speed)
        //{
        //    Model = model;
        //    Speed = speed;
        //}
        public void Start(int newSpeed) { Speed = newSpeed; }
        public void Move(int newSpeed) { Speed = newSpeed; }
        public void Stop() { Speed = 0; }        
    }
}
