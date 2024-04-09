using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionableTypes : MonoBehaviour
{
    public struct Bender 
    {
        public BaseStat stats;
        public string Name { get; set; }
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

    public enum DamageType
    {
        Pierce,
        Slashing,
        Bludgeoning
    }

    public struct Weapon
    {
        public int Range { get; set; }
        public DamageType DamageType { get; set; }
        public int DamageDice { get; set; }
        public int DiceNumber { get; set; }
    }
    //Eriþim olmadýðý için weaponName parametresini kaldýrýn uyarýsý geliyor kaldýrmayýn
    public Weapon CreateWeapon(string weaponName, int range, DamageType damageType, int damageDice, int diceNumber)
    {
        Weapon weapon = new();
        weapon.Range = range;
        weapon.DamageType = damageType;
        weapon.DamageDice = damageDice;
        weapon.DiceNumber = diceNumber;

        return weapon;
    }

    //Eriþim örneði
    //public void AllWeapons()
    //{
    //    Weapon shortBow = CreateWeapon("Kýsa Yay", 6, DamageType.Pierce, 6, 2);
    //    Weapon longBow = CreateWeapon("Uzun Yay", 8, DamageType.Pierce, 4, 2);
    //    Weapon shortSword = CreateWeapon("Kýlýç", 1, DamageType.Slashing, 8, 2);
    //    Weapon longSword = CreateWeapon("Uzun Kýlýç", 1, DamageType.Slashing, 10, 2);
    //}

}//yeni kod
