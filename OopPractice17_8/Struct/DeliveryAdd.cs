using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice17_8.Struct
{
    internal struct DeliveryAdd
    {

        public string city;
        public string street;
        public int BuildNum;

        public DeliveryAdd(string city, string street, int BuildNum)
        {
            this.city = city;
            this.street = street;
            this.BuildNum = BuildNum;

        }
        public string GetAdd()
        {
            return $"{BuildNum} , {street} ,{city}";

        }


    } 

 }
