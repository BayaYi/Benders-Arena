using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionableTypes : MonoBehaviour
{
    //Bükücü temel kodu ve yaratma
    public struct Bender 
    {
        public BaseStat stats;
        public string Name { get; set; }
        public bool IsServerFounder { get; set; }
        public int PlayerNumber { get; set; }
    }
    
    public Bender CreateCharacter(BendingAbility alinanBending, int alinanStrength, int alinanDexterity, int alinanConstitution, int alinanIntelligence, int alinanChiPower, int alinanPhysicalPower, int alinanCharisma)
    {
        switch (alinanBending)
        {
            case BendingAbility.fire:
                return CreateFireBender(alinanStrength, alinanDexterity, alinanConstitution, alinanIntelligence, alinanChiPower, alinanPhysicalPower, alinanCharisma);
            case BendingAbility.water:
                return CreateWaterBender(alinanStrength, alinanDexterity, alinanConstitution, alinanIntelligence, alinanChiPower, alinanPhysicalPower, alinanCharisma);
            case BendingAbility.earth:
                return CreateEarthBender(alinanStrength, alinanDexterity, alinanConstitution, alinanIntelligence, alinanChiPower, alinanPhysicalPower, alinanCharisma);
            case BendingAbility.air:
                return CreateAirBender(alinanStrength, alinanDexterity, alinanConstitution, alinanIntelligence, alinanChiPower, alinanPhysicalPower, alinanCharisma);
            default:
                return CreateNonBender(alinanStrength, alinanDexterity, alinanConstitution, alinanIntelligence, alinanChiPower, alinanPhysicalPower, alinanCharisma);
        }
    }
    public Bender CreateEarthBender(int alinanStrength, int alinanDexterity, int alinanConstitution, int alinanIntelligence, int alinanChiPower, int alinanPhysicalPower, int alinanCharisma)
    {
        Bender bender = new Bender();        
        bender.stats.Strength = alinanStrength;
        bender.stats.Dexterity = alinanDexterity;
        bender.stats.Constitution = alinanConstitution;
        bender.stats.Intelligence = alinanIntelligence;
        bender.stats.ChiPower = alinanChiPower;
        bender.stats.PhysicalPower = alinanPhysicalPower;
        bender.stats.Charisma = alinanCharisma;

        bender.stats.TotalHealth = 30 + (12*bender.stats.Constitution);
        bender.stats.TotalPhysicalEnergy = (bender.stats.Constitution + bender.stats.PhysicalPower);
        bender.stats.TotalChiEnergy = (bender.stats.ChiPower);
        bender.stats.TotalSpeed = (bender.stats.Dexterity + 2);
        bender.stats.TotalPhysicalDefence = (bender.stats.Dexterity + 10);
        bender.stats.TotalBendingDefence = (bender.stats.TotalPhysicalDefence + bender.stats.ChiPower);
        bender.stats.TotalInitiative = (bender.stats.Dexterity + bender.stats.Intelligence);
        return bender;
    }
    public Bender CreateFireBender(int alinanStrength, int alinanDexterity, int alinanConstitution, int alinanIntelligence, int alinanChiPower, int alinanPhysicalPower, int alinanCharisma)
    {
        Bender bender = new Bender();
        bender.stats.Strength = alinanStrength;
        bender.stats.Dexterity = alinanDexterity;
        bender.stats.Constitution = alinanConstitution;
        bender.stats.Intelligence = alinanIntelligence;
        bender.stats.ChiPower = alinanChiPower;
        bender.stats.PhysicalPower = alinanPhysicalPower;
        bender.stats.Charisma = alinanCharisma;

        bender.stats.TotalHealth = 20 + (8 * bender.stats.Constitution);
        bender.stats.TotalPhysicalEnergy = (bender.stats.Constitution + bender.stats.PhysicalPower);
        bender.stats.TotalChiEnergy = (bender.stats.ChiPower);
        bender.stats.TotalSpeed = (bender.stats.Dexterity + 2);
        bender.stats.TotalPhysicalDefence = (bender.stats.Dexterity + 10);
        bender.stats.TotalBendingDefence = (bender.stats.TotalPhysicalDefence + bender.stats.ChiPower);
        bender.stats.TotalInitiative = (bender.stats.Dexterity + bender.stats.Intelligence);
        return bender;
    }
    public Bender CreateWaterBender(int alinanStrength, int alinanDexterity, int alinanConstitution, int alinanIntelligence, int alinanChiPower, int alinanPhysicalPower, int alinanCharisma)
    {
        Bender bender = new Bender();
        bender.stats.Strength = alinanStrength;
        bender.stats.Dexterity = alinanDexterity;
        bender.stats.Constitution = alinanConstitution;
        bender.stats.Intelligence = alinanIntelligence;
        bender.stats.ChiPower = alinanChiPower;
        bender.stats.PhysicalPower = alinanPhysicalPower;
        bender.stats.Charisma = alinanCharisma;

        bender.stats.TotalHealth = 20 + (8 * bender.stats.Constitution);
        bender.stats.TotalPhysicalEnergy = (bender.stats.Constitution + bender.stats.PhysicalPower);
        bender.stats.TotalChiEnergy = (bender.stats.ChiPower);
        bender.stats.TotalSpeed = (bender.stats.Dexterity + 2);
        bender.stats.TotalPhysicalDefence = (bender.stats.Dexterity + 10);
        bender.stats.TotalBendingDefence = (bender.stats.TotalPhysicalDefence + bender.stats.ChiPower);
        bender.stats.TotalInitiative = (bender.stats.Dexterity + bender.stats.Intelligence);
        return bender;
    }
    public Bender CreateAirBender(int alinanStrength, int alinanDexterity, int alinanConstitution, int alinanIntelligence, int alinanChiPower, int alinanPhysicalPower, int alinanCharisma)
    {
        Bender bender = new Bender();
        bender.stats.Strength = alinanStrength;
        bender.stats.Dexterity = alinanDexterity;
        bender.stats.Constitution = alinanConstitution;
        bender.stats.Intelligence = alinanIntelligence;
        bender.stats.ChiPower = alinanChiPower;
        bender.stats.PhysicalPower = alinanPhysicalPower;
        bender.stats.Charisma = alinanCharisma;

        bender.stats.TotalHealth = 15 + (6 * bender.stats.Constitution);
        bender.stats.TotalPhysicalEnergy = (bender.stats.Constitution + bender.stats.PhysicalPower);
        bender.stats.TotalChiEnergy = (bender.stats.ChiPower);
        bender.stats.TotalSpeed = (bender.stats.Dexterity + 2);
        bender.stats.TotalPhysicalDefence = (bender.stats.Dexterity + 10);
        bender.stats.TotalBendingDefence = (bender.stats.TotalPhysicalDefence + bender.stats.ChiPower);
        bender.stats.TotalInitiative = (bender.stats.Dexterity + bender.stats.Intelligence);
        return bender;
    }
    public Bender CreateNonBender(int alinanStrength, int alinanDexterity, int alinanConstitution, int alinanIntelligence, int alinanChiPower, int alinanPhysicalPower, int alinanCharisma)
    {
        Bender bender = new Bender();
        bender.stats.Strength = alinanStrength;
        bender.stats.Dexterity = alinanDexterity;
        bender.stats.Constitution = alinanConstitution;
        bender.stats.Intelligence = alinanIntelligence;
        bender.stats.ChiPower = alinanChiPower;
        bender.stats.PhysicalPower = alinanPhysicalPower;
        bender.stats.Charisma = alinanCharisma;

        bender.stats.TotalHealth = 20 + (4 * bender.stats.Constitution);
        bender.stats.TotalPhysicalEnergy = (bender.stats.Constitution + bender.stats.PhysicalPower);
        bender.stats.TotalChiEnergy = (bender.stats.ChiPower);
        bender.stats.TotalSpeed = (bender.stats.Dexterity + 2);
        bender.stats.TotalPhysicalDefence = (bender.stats.Dexterity + 10);
        bender.stats.TotalBendingDefence = (bender.stats.TotalPhysicalDefence + bender.stats.ChiPower);
        bender.stats.TotalInitiative = (bender.stats.Dexterity + bender.stats.Intelligence);
        return bender;
    }


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
