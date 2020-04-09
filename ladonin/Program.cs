using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ladonin
{
    class Program
    {
        static void Main(string[] args)
        {
           TransportShip ship = new TransportShip();

            string res = ship.Move(2000);

            Console.WriteLine(res);


            Console.ReadLine();
        }

        public class BaseShip
        {
            public BaseShip()
            {
                Console.WriteLine("Вызван конструкор родительского класса");

            }

            private int counter;

            public int speed;

            public string Move (int disnance)
            {
                counter++;

                string result = string.Format("Пройдено километров " + disnance);

                return result;
            }

        }
        
        public  class AnotherBaseShip 
        {

        }

        public class TransportShip : BaseShip 
        {
            public TransportShip()
            {
                Console.WriteLine("Вызван конструкор дочерного класса");
            }
            public void Start()
            {

            }
        }
             

    }
}
