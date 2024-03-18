using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputKaydetCode : MonoBehaviour

{

    [SerializeField] private InputField _healthInput;
    [SerializeField] private InputField _physicalEnergyInput;
    [SerializeField] private InputField _chiEnergyInput;
    [SerializeField] private InputField _speedInput;
    [SerializeField] private InputField _physicalDefenceInput;
    [SerializeField] private InputField _bendingDefenceInput;
    [SerializeField] private InputField _initiativeInput;
    [SerializeField] private InputField _strengthInput;
    [SerializeField] private InputField _dexterityInput;
    [SerializeField] private InputField _constitutionInput;
    [SerializeField] private InputField _intelligenceInput;
    [SerializeField] private InputField _physicalPowerInput;
    [SerializeField] private InputField _chiPowerInput;
    [SerializeField] private InputField _charismaInput;

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



    public void SavePlayerData()
    {

        _health = int.Parse(_healthInput.text);
        _physicalEnergy = int.Parse(_physicalEnergyInput.text);
        _chiEnergy = int.Parse(_chiEnergyInput.text);
        _speed = int.Parse(_speedInput.text);
        _physicalDefence = int.Parse(_physicalDefenceInput.text);
        _bendingDefence = int.Parse(_bendingDefenceInput.text);
        _initiative = int.Parse(_initiativeInput.text);
        _strength = int.Parse(_strengthInput.text);
        _dexterity = int.Parse(_dexterityInput.text);
        _constitution = int.Parse(_constitutionInput.text);
        _intelligence = int.Parse(_intelligenceInput.text);
        _physicalPower = int.Parse(_physicalPowerInput.text);
        _chiPower = int.Parse(_chiPowerInput.text);
        _charisma = int.Parse(_charismaInput.text);


        PlayerPrefs.SetInt("Healty", _health);
        PlayerPrefs.SetInt("PhysicalEnergy", _physicalEnergy);
        PlayerPrefs.SetInt("ChiEnergy", _chiEnergy);
        PlayerPrefs.SetInt("Speed", _speed);
        PlayerPrefs.SetInt("PhysicalDefence", _physicalDefence);
        PlayerPrefs.SetInt("BendingDefence", _bendingDefence);
        PlayerPrefs.SetInt("İnitiative", _initiative);
        PlayerPrefs.SetInt("Strength", _strength);
        PlayerPrefs.SetInt("Dexterity", _dexterity);
        PlayerPrefs.SetInt("Constitution", _constitution);
        PlayerPrefs.SetInt("Intelligence", _intelligence);
        PlayerPrefs.SetInt("PhysicalPower", _physicalPower);
        PlayerPrefs.SetInt("ChiPower", _chiPower);
        PlayerPrefs.SetInt("Charisma", _charisma);

        PlayerPrefs.Save();
    }



}

