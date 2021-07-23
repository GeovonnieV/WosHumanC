using System;

namespace WosHumanC
{

  public class Human
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;


    public void GetHealth()
        {
            System.Console.WriteLine(health);
        }
     
   
    // constructor
    public Human( string Name, int Strength = 3, int Intelligence = 3, int Dexterity = 3, int health = 100)
        {
            Name = this.Name;
            this.Strength = Strength;
            this.Intelligence = Intelligence;
            this.Dexterity = Dexterity;
            this.health = health;
        }

        public int Attack()
            {
                    int damage = this.Strength * 5;
                    int playerHealth = this.health -= damage;
                    System.Console.WriteLine(playerHealth);
                    return playerHealth;
            }

}


}