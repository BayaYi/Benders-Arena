using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionableTypes : MonoBehaviour
{
    
}
public struct Bender 
{
    public BaseStat stats;
    public string name;
    public string bending;
    public bool isServerFounder;
    public int playerNumber;
}
public struct Monster
{
    public BaseStat stats;
    public string name;
    public bool isMagical;
    public string armourType;
}
public struct Weapon
{
    public bool isMelee;
    public string damageType;
    public int damageDice;
    public int diceNumber;
}
public class ShortBow
{
    Weapon bowWeapon = new Weapon();
    //bowWeapon.isMelee== true;
}
public class LongBow 
{
    public Weapon longBowBase;
}