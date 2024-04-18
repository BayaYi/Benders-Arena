using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionableTypes : MonoBehaviour
{
    //B�k�c� temel kodu ve yaratma
    public struct Bender 
    {
        public BaseStat stats;
        public string Name { get; set; }
        public bool IsServerFounder { get; set; }
        public int PlayerNumber { get; set; }
    }
    //BaseStats'a veri �ekme kodu
    //public BaseStat DataExtraction(int bending, int strentgh, int dexterity, int constitution, int intelligence, int physicalPower, int chiPower, int charisma)
    //{

    //}

    //yaratma kodu
    //public Bender CreateBender(BendingAbility ability, int strentgh, int dexterity, int constitution, int intelligence, int physicalPower, int chiPower , int char�sma )
    //{
    //    Bender bender = new();

    //}


    //Canavar temel kodu ve yaratma
    public struct Monster
    {
        public BaseStat stats;
        public string Name { get; set; }
        public bool IsMagical { get; set; }
        public string ArmourType { get; set; }
    }



    //Silah temel kodu ve yaratma
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
    //Eri�im olmad��� i�in weaponName parametresini kald�r�n uyar�s� geliyor kald�rmay�n
    public Weapon CreateWeapon(string weaponName, int range, DamageType damageType, int damageDice, int diceNumber)
    {
        Weapon weapon = new();
        weapon.Range = range;
        weapon.DamageType = damageType;
        weapon.DamageDice = damageDice;
        weapon.DiceNumber = diceNumber;

        return weapon;
    }

    //Eri�im �rne�i
    //public void AllWeapons()
    //{
    //    Weapon shortBow = CreateWeapon("K�sa Yay", 6, DamageType.Pierce, 6, 2);
    //    Weapon longBow = CreateWeapon("Uzun Yay", 8, DamageType.Pierce, 4, 2);
    //    Weapon shortSword = CreateWeapon("K�l��", 1, DamageType.Slashing, 8, 2);
    //    Weapon longSword = CreateWeapon("Uzun K�l��", 1, DamageType.Slashing, 10, 2);
    //}

}//yeni kod
