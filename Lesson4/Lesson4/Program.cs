using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            var Building = new BuildingProg();
           
            Building.FloorHeight(70,20);
            Building.FlatInEntrance(400,4);
            Building.FlatInFloor(400,20);

            var Building2 = new BuildingProg();

            Building2.FloorHeight(80,30);
            Building2.FlatInEntrance(300,5);
            Building2.FlatInFloor(300,30);
        }
       
    }

}
