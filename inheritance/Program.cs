using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier man = new Soldier();
            man.SetGun(new Rifle());
            man.KillEnemy();
        }
    }
}
