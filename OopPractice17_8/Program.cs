
using OopPractice17_8.Struct;

namespace OopPractice17_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1 : 
            // a: the original variable doesn't change due to the struct copy behavior so only
            //the copy us affected (struct is a value type)
            //b : both original and copy change bec class doesn't have copy behavior (refrence type)
            DeliveryCenter center = new DeliveryCenter();

            Shipment sh1 = new Shipment();
            DeliveryAdd add1 = new DeliveryAdd();
            Shipment sh2 = new Shipment();
            DeliveryAdd add2 = new DeliveryAdd();
            Shipment sh3 = new Shipment();
            DeliveryAdd add3 = new DeliveryAdd();
            double Weight;
            decimal fee;
            int buildnum;

            Console.WriteLine("Enter shipment  1 Data ; ");
            Console.WriteLine();
            Console.WriteLine($"Tracking code : ");
            sh1.TrackingCode = Console.ReadLine();
            Console.WriteLine("Desription : ");
            sh1.Description = Console.ReadLine();
            Console.WriteLine("weight : ");
            double.TryParse(Console.ReadLine(), out Weight);
            sh1.Weight = Weight;
            Console.WriteLine("enter Delivery fee : ");
            //Decimal fee;
            Decimal.TryParse(Console.ReadLine(), out fee);
            sh1.ApplyFee(fee);
            Console.WriteLine("City : ");
            add1.city = Console.ReadLine();
            Console.WriteLine("Street  : ");
            add1.street = Console.ReadLine();
            Console.WriteLine("enterbuilding number ");
            int.TryParse(Console.ReadLine(), out buildnum);
            add1.BuildNum = buildnum;
            sh1.Destination = add1;
            center.AddShipment(sh1);

            Console.WriteLine("///////////////////////////////////////////");

            Console.WriteLine("Enter shipment  2 Data ; ");
            Console.WriteLine();
            Console.WriteLine("Tracking code : ");
            sh2.TrackingCode = Console.ReadLine();
            Console.WriteLine("Desription : ");
            sh2.Description = Console.ReadLine();
            Console.WriteLine("weight : ");
            double.TryParse(Console.ReadLine(), out Weight);
            sh2.Weight = Weight;
            Console.WriteLine("enter Delivery fee : ");
            //Decimal fee;
            Decimal.TryParse(Console.ReadLine(), out fee);
            sh2.ApplyFee(fee);
            Console.WriteLine("City : ");
            add2.city = Console.ReadLine();
            Console.WriteLine("Street  : ");
            add2.street = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out buildnum);
            add2.BuildNum = buildnum;
            center.AddShipment(sh2);

            Console.WriteLine("//////////////////////////////////////////");

            Console.WriteLine("Enter shipment  2 Data ; ");
            Console.WriteLine();
            Console.WriteLine($"Tracking code : ");
            sh3.TrackingCode = Console.ReadLine();
            Console.WriteLine("Desription : ");
            sh3.Description = Console.ReadLine();
            Console.WriteLine("weight : ");
            double.TryParse(Console.ReadLine(), out Weight);
            sh3.Weight = Weight;
            Console.WriteLine("enter Delivery fee : ");
            //Decimal fee;
            Decimal.TryParse(Console.ReadLine(), out fee);
            sh3.ApplyFee(fee);
            Console.WriteLine("City : ");
            add3.city = Console.ReadLine();
            Console.WriteLine("Street  : ");
            add3.street = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out buildnum);
            add3.BuildNum = buildnum;
            center.AddShipment(sh3);

            Console.WriteLine("//////////////////////////////////////////");

            center[0].PrintShipment();
            center[1].PrintShipment();
            center[2].PrintShipment();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("please enter tracking code : ");
            string? TR;
            TR = Console.ReadLine();
            center[TR].PrintShipment();
            #region practice

            //center[0] = sh1;
            //center[1] = sh2;
            //center[2] = sh3;
            //center[0].PrintShipment();
            //center[1].PrintShipment();
            //// center["lap top"].PrintShipment();
            //Shipment ship = new Shipment("1010", "iphone", 10.2, 100, new DeliveryAdd("giza", "pooo", 2));
            //center.AddShipment(ship);
            //center[3].PrintShipment();
            #endregion


        }
    }
}
