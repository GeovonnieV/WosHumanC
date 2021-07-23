using System;

namespace WosHumanC
{
    class Program
    {
        static void Main(string[] args)
        {
            Human geo = new Human("Geo");
            geo.GetHealth();
            geo.Attack();
        }
    }
}
