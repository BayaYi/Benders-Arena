using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputGösterCode : MonoBehaviour


{
    [SerializeField] private Text _healthText;
    [SerializeField] private Text _physicalEnergyText;
    [SerializeField] private Text _chiEnergyText;
    [SerializeField] private Text _speedText;
    [SerializeField] private Text _physicalDefenceText;
    [SerializeField] private Text _bendingDefenceText;
    [SerializeField] private Text _initiativeText;
    [SerializeField] private Text _strengthText;
    [SerializeField] private Text _dexterityText;
    [SerializeField] private Text _constitutionText;
    [SerializeField] private Text _intelligenceText;
    [SerializeField] private Text _physicalPowerText;
    [SerializeField] private Text _chiPowerText;
    [SerializeField] private Text _charismaText;


    private int _health;
    private int _physicalEnergy;
    private int _chiEnergy;
    private int _speed;
    private int _physicalDefence;
    private int _bendingDefence;
    private int _initiative;
    private int _strength;
    private int _dexterity;
    private int _constitution;
    private int _intelligence;
    private int _physicalPower;
    private int _chiPower;
    private int _charisma;


    private void Start()
    {
        _health = PlayerPrefs.GetInt("Healty");
        _physicalEnergy = PlayerPrefs.GetInt("PhysicalEnergy");
        _chiEnergy = PlayerPrefs.GetInt("ChiEnergy");
        _speed = PlayerPrefs.GetInt("Speed");
        _physicalDefence = PlayerPrefs.GetInt("PhysicalDefence");
        _bendingDefence = PlayerPrefs.GetInt("BendingDefence");
        _initiative = PlayerPrefs.GetInt("İnitiative");
        _strength = PlayerPrefs.GetInt("Strength");
        _dexterity = PlayerPrefs.GetInt("Dexterity");
        _constitution = PlayerPrefs.GetInt("Constitution");
        _intelligence = PlayerPrefs.GetInt("Intelligence");
        _physicalPower = PlayerPrefs.GetInt("PhysicalPower");
        _chiPower = PlayerPrefs.GetInt("ChiPower");
        _charisma = PlayerPrefs.GetInt("Charisma");

        // UI elemanlarını güncelle

        _healthText.text = "" + _health.ToString();
        _physicalEnergyText.text = "" + _physicalEnergy.ToString();
        _chiEnergyText.text = "" + _chiEnergy.ToString();
        _speedText.text = "" + _speed.ToString();
        _physicalDefenceText.text = "" + _physicalDefence.ToString();
        _bendingDefenceText.text = "" + _bendingDefence.ToString();
        _initiativeText.text = "" + _initiative.ToString();
        _strengthText.text = "" + _strength.ToString();
        _dexterityText.text = "" + _dexterity.ToString();
        _constitutionText.text = "" + _constitution.ToString();
        _intelligenceText.text = "" + _intelligence.ToString();
        _physicalPowerText.text = "" + _physicalPower.ToString();
        _chiPowerText.text = "" + _chiPower.ToString();
        _charismaText.text = "" + _charisma.ToString();


    }
}


