using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice17_8.Struct
{
    class Shipment
    {


        string trackingCode;
        string description;
        double weight;
        decimal deliveryFee;
        decimal NewFee;
        //////////////
        #region properites
        public string TrackingCode
        {

            get { return trackingCode; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tracking code cannot be empty.");
                }
                trackingCode = value;
            }
        }

        public string Description
        {
            get { return description; }
            //read onlyyyy
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAdd Destination { get; set; }


        public decimal EstimatedCost
        {
            get
            {
                return deliveryFee + ((decimal)weight * 5);
            }
        }

        #endregion

        #region constructor

        public void UpdateDeliveryFee(decimal NewFee)
        {
            if (NewFee > 0)
                this.NewFee = NewFee;

        }

        public Shipment()
        {

        }

        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAdd destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }
        public void PrintShipment()
        {
            Console.WriteLine($"---------shipment data----------");
            Console.WriteLine($"Tracking code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Weight : {Weight}");
            Console.WriteLine($"Delivery fee : {DeliveryFee}");
            Console.WriteLine($"Destination : {Destination.GetAdd()}");
            Console.WriteLine($"Estimated cost : {EstimatedCost}");
        }

        public void ApplyFee(decimal fee)
        {
            DeliveryFee = fee;
        }

        #endregion

    }
}
