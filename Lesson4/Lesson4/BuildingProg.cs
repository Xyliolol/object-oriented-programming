using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class BuildingProg
    {

        private int BuidingNumber;
        static int count = 1;
        private int floor ;
        private int flat ;
        private int entrance ;
        private float height ;
        public void Building(int _floor, int _flat, int _entrance, float _height)
        {
            BuidingNumber = CountPlus(count);
            height = _height;
            floor = _floor;
            flat = _flat;
            entrance = _entrance;

        }
          
        public void FloorHeight(float height,int floor)
        {
              BuidingNumber = count++;
            Console.WriteLine($"номер дома {BuidingNumber}");
            float floorheight = height / floor;
            Console.WriteLine($"высота этажа составляет {floorheight} метра"); 
        }
        public void FlatInEntrance(int flat , int entrance)
        {
            int flatinentrance = flat / entrance;
            Console.WriteLine($"количество квартир в подьезде :{flatinentrance}");
        }
        public void FlatInFloor(int flat, int floor)
        {
            int flatinfloor = flat / floor ;
            Console.WriteLine($"квартир на лесничной площадке:{flatinfloor}");
        }
        public int CountPlus(int count)
        {
            return count++;
        }
       
    }
}
