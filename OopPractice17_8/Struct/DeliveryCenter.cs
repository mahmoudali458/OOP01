using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice17_8.Struct
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments = new Shipment[10];

        public DeliveryCenter()
        {
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < 10 )
                {
                    return shipments[index];
                }

                return null;
            }

            set
            {
                if (index >= 0 && index < 10)
                {
                    shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < 10; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                    else { Console.WriteLine( "not found "); }
                }
                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for(int i=0;i<10;i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    Console.WriteLine("Shipment was successfully added");
                    return true;
                    
                } 

            }
            return false;
        }

        //public Shipment this[string description]
        //{
        //    get
        //    {
        //        for (int i = 0; i < shipments.Length; i++)
        //        {
        //            if (shipments[i] != null && shipments[i].Description == description)
        //            {
        //                return shipments[i];
        //            }
        //        }
        //        return null;
        //    }

        //}

    }

}
