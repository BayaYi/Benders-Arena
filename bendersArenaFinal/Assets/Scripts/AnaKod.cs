using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class AnaKod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public enum BendingType
{
    none,fire,earth,water,air
}

public struct Character
{
    public string name {  get; set; }
    //Temel Özellikler
    public BendingType Bending { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int PhysicalPower { get; set; }
    public int ChiPower { get; set; }
    public int Charisma { get; set; }
    //Türetilmiþ statlar
    public int TotalHealth {get; set;}
    public int TotalPhysicalEnergy { get; set; }
    public int TotalChiEnergy { get; set; }
    public int Speed { get; set; }
    public int PhysicalDefence { get; set; }
    public int BendingDefence { get; set; }
    public int Initiative { get; set; }
    //Güncel Durumlar
    public int CurrentHealth { get; set; }
    public int CurrentPhysicalEnergy { get; set; }
    public int CurrentChiEnergy { get; set; }

    //methodlar
    //karakter yaratma
    //kodun kullanýmý
    public Character(string isim,BendingType bending,int strength, int dexterity, int constitution, int intelligence, int physicalPower, int chiPower, int charisma)
    {
        this.name = isim;
        this.Bending = bending;
        this.Strength = strength;
        this.Dexterity = dexterity;
        this.Constitution = constitution;
        this.Intelligence = intelligence; 
        this.PhysicalPower = physicalPower;
        this.ChiPower = chiPower;
        this.Charisma = charisma;
        int canTemel = 0;
        int canCarpan = 0;
        switch (bending)
        {
            case BendingType.none:
                break;
            case BendingType.fire:
                canTemel = 20;
                canCarpan = 8;
                break;
            case BendingType.earth:
                canTemel = 30;
                canCarpan = 12;
                break;
            case BendingType.water:
                canTemel = 20;
                canCarpan = 8;
                break;
            case BendingType.air:
                canTemel = 15;
                canCarpan = 6;
                break;
            default:
                break;
        }
        this.TotalHealth = canTemel + (canCarpan * constitution);
        this.TotalPhysicalEnergy = constitution + physicalPower;
        this.TotalChiEnergy= chiPower;
        this.Speed = dexterity + 2;
        this.PhysicalDefence = 10 + dexterity;
        this.BendingDefence = this.PhysicalDefence + chiPower;
        this.Initiative = dexterity + intelligence;
        this.CurrentHealth = this.TotalHealth;
        this.CurrentPhysicalEnergy = this.TotalPhysicalEnergy;
        this.CurrentChiEnergy = this.TotalChiEnergy;
    }


}
