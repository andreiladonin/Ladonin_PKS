using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ladonin
{
    class Program
    {
        public enum ShipType
        {
            TransportShip = 1,
            FightShip = 2
        }
        static void Main(string[] args)
        {

            BaseShip ship = GetShip(ShipType.FightShip);
            string res = ship.Fight();

            Console.WriteLine(res);
            Console.ReadKey();
        }


        static BaseShip GetShip(ShipType shipType)
        {
            switch (shipType)
            {
                case ShipType.FightShip:
                    return new FightShip();
                case ShipType.TransportShip:
                    return new TransportShip();
                default:
                    throw new Exception("Неизвестный тип корабля");
            }
        }

        public class BaseShip
        {
            public virtual string Move(int distasnce)
            {
                string result = String.Format("Пройдено км {0}", distasnce);
                return result;
            }

            public virtual string Fight()
            {
                return "Произошел бой";
            }
        }

        public class TransportShip : BaseShip
        {
            public override string Move(int distasnce)
            {
                double time = (double)distasnce / 1000;

                return string.Format("Пройдено км {0} за время {1}", distasnce, time);
            }

            public override string Fight()
            {
                return "Транспортный корабль не может вступить в бой"; 
            }

            public override string ToString()
            {
                return "Транспортный корабль";
            }

        }

        public class FightShip : BaseShip
        {
            public override string Move(int distasnce)
            {
                double time = (double)distasnce / 2000;

                return string.Format("Пройдено км {0} за время {1}", distasnce, time);
            }

            public override string Fight()
            {
                return "Противник уничтожен";
            }

            public override string ToString()
            {
                return "Боевой корабль";
            }

        }







        //public class BaseShip
        //{
        //    //public BaseShip()
        //    //{
        //    //    Console.WriteLine("Вызван конструкор родительского класса");

        //    //}

        //    private int counter;

        //    public int speed;

        //    public virtual string Move (int disnance)
        //    {
        //        counter++;

        //        string result = string.Format("Пройдено километров " + disnance);

        //        return result;
        //    }

        //    public override string ToString()
        //    {
        //        return "Базовый класс всех кораблей";
        //    }
        //}

        //public class TransportShip : BaseShip 
        //{
        //    //public TransportShip()
        //    //{
        //    //    Console.WriteLine("Вызван конструкор дочерного класса");
        //    //}
        //    //public void Start()
        //    //{
        //    //}


        //    public override string Move(int distance)
        //    {
        //        string result = base.Move(distance);
        //        result += string.Format("\r\nТраспортный корабль преодолел км: {0}", distance);

        //        return result;

        //    }

        //    public override string ToString()
        //    {
        //        return "Транспортный корабль подбит";
        //    }
        //}


    }
}
