using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats : MonoBehaviour
{
    
        
}
public struct BaseStat 
{
    //Bükme Yeteneði
    public int bendingAbility { get; set; }
    //Temel Statlar
    public int strength { get; set; }
    public int dexterity { get; set; }
    public int constitution { get; set; }
    public int intelligence { get; set; }
    public int physicalPower { get; set; }
    public int chiPower { get; set; }
    public int charisma { get; set; }
    //Türetilmiþ Statlar
    public int totalHealth { get; set; }
    public int totalPhysicalEnergy { get; set; }
    public int TotalChiEnergy { get; set; }
    public int totalSpeed { get; set; }
    public int totalPhysicalDefence { get; set; }
    public int totalBendingDefence { get; set; }
    public int totalInitiative { get; set; }
    //Güncel Durumlar
    public int currentHealth { get; set; }
    public int currentPhysicalEnergy { get; set; }
    public int currentChiEnergy { get; set; }
    public int currentSpeed { get; set; }
    public int currentPhysicalDefence { get; set; }
    public int currentBendingDefence { get; set; }
    public int currentInitiative { get; set; }
}
