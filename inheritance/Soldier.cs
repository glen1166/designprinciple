using System;
namespace inheritance{
    public class Soldier{
        private AbstractGun _gun;
        public void SetGun(AbstractGun gun){
            _gun = gun;
        }

        public void KillEnemy(){
            Console.WriteLine("kill eneymy.");
        }
    }
}
