using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats : MonoBehaviour
{
     
}
public enum BendingAbility
{
    none,
    fire,
    water,
    earth,
    air
}

public struct BaseStat
{
    //Bükme Yeteneði
    //0 diðer 1 ateþ 2 su 3 toprak 4 hava
    public BendingAbility BendingAbility { get; set; }
    //Temel Statlar
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int PhysicalPower { get; set; }
    public int ChiPower { get; set; }
    public int Charisma { get; set; }
    //Türetilmiþ Statlar
    public int TotalHealth { get; set; }
    public int TotalPhysicalEnergy { get; set; }
    public int TotalChiEnergy { get; set; }
    public int TotalSpeed { get; set; }
    public int TotalPhysicalDefence { get; set; }
    public int TotalBendingDefence { get; set; }
    public int TotalInitiative { get; set; }
    //Güncel Durumlar
    public int CurrentHealth { get; set; }
    public int CurrentPhysicalEnergy { get; set; }
    public int CurrentChiEnergy { get; set; }
    public int CurrentSpeed { get; set; }
    public int CurrentPhysicalDefence { get; set; }
    public int CurrentBendingDefence { get; set; }
    public int CurrentInitiative { get; set; }
}




