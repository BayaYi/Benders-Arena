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
    //B�kme Yetene�i
    //0 di�er 1 ate� 2 su 3 toprak 4 hava
    public BendingAbility BendingAbility { get; set; }
    //Temel Statlar
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int PhysicalPower { get; set; }
    public int ChiPower { get; set; }
    public int Charisma { get; set; }
    //T�retilmi� Statlar
    public int TotalHealth { get; set; }
    public int TotalPhysicalEnergy { get; set; }
    public int TotalChiEnergy { get; set; }
    public int TotalSpeed { get; set; }
    public int TotalPhysicalDefence { get; set; }
    public int TotalBendingDefence { get; set; }
    public int TotalInitiative { get; set; }
    //G�ncel Durumlar
    public int CurrentHealth { get; set; }
    public int CurrentPhysicalEnergy { get; set; }
    public int CurrentChiEnergy { get; set; }
    public int CurrentSpeed { get; set; }
    public int CurrentPhysicalDefence { get; set; }
    public int CurrentBendingDefence { get; set; }
    public int CurrentInitiative { get; set; }
}

//public BaseStat GetBaseStatFromUI()
//{
//    // Kullan�c� aray�z� ��elerini tan�mlay�n
//    TextBox bendingTextBox = new TextBox();
//    TextBox strengthTextBox = new TextBox();
//    TextBox dexterityTextBox = new TextBox();
//    TextBox constitutionTextBox = new TextBox();
//    TextBox intelligenceTextBox = new TextBox();
//    TextBox physicalPowerTextBox = new TextBox();
//    TextBox chiPowerTextBox = new TextBox();
//    TextBox charismaTextBox = new TextBox();

//    // Kullan�c�dan veri giri�ini al�n
//    bendingTextBox.Show();
//    strengthTextBox.Show();
//    dexterityTextBox.Show();
//    constitutionTextBox.Show();
//    intelligenceTextBox.Show();
//    physicalPowerTextBox.Show();
//    chiPowerTextBox.Show();
//    charismaTextBox.Show();

//    int bending = int.Parse(bendingTextBox.Text);
//    int strength = int.Parse(strengthTextBox.Text);
//    int dexterity = int.Parse(dexterityTextBox.Text);
//    int constitution = int.Parse(constitutionTextBox.Text);
//    int intelligence = int.Parse(intelligenceTextBox.Text);
//    int physicalPower = int.Parse(physicalPowerTextBox.Text);
//    int chiPower = int.Parse(chiPowerTextBox.Text);
//    int charisma = int.Parse(charismaTextBox.Text);

//    // Girilen de�erleri BaseStat yap�s�na atay�n
//    BaseStat baseStat = new BaseStat
//    {
//        Bending = bending,
//        Strength = strength,
//        Dexterity = dexterity,
//        Constitution = constitution,
//        Intelligence = intelligence,
//        PhysicalPower = physicalPower,
//        ChiPower = chiPower,
//        Charisma = charisma
//    };

//    return baseStat;
//}





