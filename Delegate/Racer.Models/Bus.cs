namespace Racer.Models
{
    public class Bus : Car
    {
        public int PassengerQuantity { get; set; }
        public Bus(string model, int speed, int passengerQuantity) {
            Model = model;
            if (passengerQuantity > 9) passengerQuantity = 9;
            Speed = speed  - (speed * (passengerQuantity / 10));      //штраф за пассажиров
        }      
    }
}
