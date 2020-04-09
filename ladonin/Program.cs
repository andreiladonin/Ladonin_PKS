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

            string res = ship.ToString();

            Console.WriteLine(res);


            Console.ReadLine();
        }

        public class BaseShip
        {
            //public BaseShip()
            //{
            //    Console.WriteLine("Вызван конструкор родительского класса");

            //}

            private int counter;

            public int speed;

            public virtual string Move (int disnance)
            {
                counter++;

                string result = string.Format("Пройдено километров " + disnance);

                return result;
            }

            public override string ToString()
            {
                return "Базовый класс всех кораблей";
            }
        }

        public class TransportShip : BaseShip 
        {
            //public TransportShip()
            //{
            //    Console.WriteLine("Вызван конструкор дочерного класса");
            //}
            //public void Start()
            //{
            //}


            public override string Move(int distance)
            {
                string result = base.Move(distance);
                result += string.Format("\r\nТраспортный корабль преодолел км: {0}", distance);

                return result;

            }
        }
             

    }
}
