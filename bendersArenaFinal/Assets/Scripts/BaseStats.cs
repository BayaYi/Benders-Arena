using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStats : MonoBehaviour
{
    
        
}
public struct BaseStat 
{
    //Temel Statlar
    public int strength;
    public int dexterity;
    public int constitution;
    public int intelligence;
    public int physicalPower;
    public int chiPower;
    public int charisma;
    //Türetilmiþ Statlar
    public int totalHealth;
    public int totalPhysicalEnergy;
    public int TotalChiEnergy;
    public int totalSpeed;
    public int totalPhysicalDefence;
    public int totalBendingDefence;
    public int totalInitiative;
    //Güncel Durumlar
    public int currentHealth;
    public int currentPhysicalEnergy;
    public int currentChiEnergy;
    public int currentSpeed;
    public int currentPhysicalDefence;
    public int currentBendingDefence;
    public int currentInitiative;
}
