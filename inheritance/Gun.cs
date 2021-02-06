using System;
namespace inheritance{
    public class HandGun : AbstractGun{
        public override void Shoot(){
            Console.WriteLine("handgun shoot.");
        }
    }

    public class Rifle : AbstractGun{
        public override void Shoot(){
            Console.WriteLine(" rifle shoot..");
        }
    }
    public class MachineGun : AbstractGun{
        public override void Shoot(){
            Console.WriteLine("handgun shoot.");
        }
    }
}
