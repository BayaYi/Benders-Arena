using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionableTypes : MonoBehaviour
{
    public struct Bender 
{
    public BaseStat stats;
    public string name { get; set; }
    public string bending { get; set; }
    public bool isServerFounder { get; set; }
    public int playerNumber { get; set; }
}
    public struct Monster
{
    public BaseStat stats;
    public string name { get; set; }
    public bool isMagical { get; set; }
    public string armourType { get; set; }
}
    public struct Weapon
    {
        public bool isMelee { get; set; }
        public string damageType { get; set; }
        public int damageDice { get; set; }
        public int diceNumber { get; set; }
    }
    void shortBow(Weapon weapon)
    {
        weapon.isMelee = false;
        weapon.damageType = "pierce";
        weapon.damageDice = 6;
        weapon.diceNumber = 2;
    }
    void longBow(Weapon weapon)
    {
        weapon.isMelee=false;
        weapon.damageType = "pierce";
        weapon.damageDice = 4;
        weapon.diceNumber = 2;
    }
    void shortSword(Weapon weapon)
    {
        weapon.isMelee = true;
        weapon.damageType = "slashing";
        weapon.damageDice = 8;
        weapon.diceNumber = 2;
    }
    void longSword(Weapon weapon)
    {
        weapon.isMelee = false;
        weapon.damageType = "slashing";
        weapon.damageDice = 10;
        weapon.diceNumber = 2;
    }
}//yeni kod
