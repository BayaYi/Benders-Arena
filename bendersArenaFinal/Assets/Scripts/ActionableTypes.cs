using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionableTypes : MonoBehaviour
{
    public struct Bender 
{
    public BaseStat stats;
    public string Name { get; set; }
    public string Bending { get; set; }
    public bool IsServerFounder { get; set; }
    public int PlayerNumber { get; set; }
}
    public struct Monster
{
    public BaseStat stats;
    public string Name { get; set; }
    public bool IsMagical { get; set; }
    public string ArmourType { get; set; }
}
    public struct Weapon
    {
        public int Range { get; set; }
        public int DamageType { get; set; }// 0 pierce, 1 slahsing, 2 bludgeoning
        public int DamageDice { get; set; }
        public int DiceNumber { get; set; }
    }
    public void ShortBow(Weapon weapon)
    {
        weapon.Range = 6;
        weapon.DamageType = 0;
        weapon.DamageDice = 6;
        weapon.DiceNumber = 2;
    }
    public void LongBow(Weapon weapon)
    {
        weapon.Range= 8;
        weapon.DamageType = 0;
        weapon.DamageDice = 4;
        weapon.DiceNumber = 2;
    }
    public void ShortSword(Weapon weapon)
    {
        weapon.Range = 1;
        weapon.DamageType = 1;
        weapon.DamageDice = 8;
        weapon.DiceNumber = 2;
    }
    public void LongSword(Weapon weapon)
    {
        weapon.Range = 1;
        weapon.DamageType = 1;
        weapon.DamageDice = 10;
        weapon.DiceNumber = 2;
    }
}//yeni kod
