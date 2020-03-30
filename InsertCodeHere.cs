using System;

namespace RolePlayV11
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Warrior warriorA = new Warrior("Ragnar", 85);
            Warrior warriorB = new Warrior("Lagertha", 100);

            Console.WriteLine($"Warrior A is called {warriorA.Name} is level {warriorA.Level}");
            Console.WriteLine($"Warrior B is called {warriorB.Name} is level {warriorB.Level}");

            while(!warriorA.Dead && !warriorB.Dead){
                warriorB.TakeDamage(warriorA.DealDamage());
                Console.WriteLine($"Warrior B has {warriorB.HitPoints} hitpoints left!");
                if(warriorB.Dead){
                    break;
                }
                warriorA.TakeDamage(warriorB.DealDamage());
                Console.WriteLine($"Warrior A has {warriorA.HitPoints} hitpoints left!");
            }

            if(warriorA.Dead){
                Console.WriteLine($"Warrior B won with {warriorB.HitPoints} hitpoints left.");
            }else{
                Console.WriteLine($"Warrior A won with {warriorA.HitPoints} hitpoints left.");
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}