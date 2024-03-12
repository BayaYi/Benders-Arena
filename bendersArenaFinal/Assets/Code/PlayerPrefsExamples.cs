using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsExamples : MonoBehaviour
{
    [SerializeField] private InputField _nameInput;
    [SerializeField] private InputField _experienceInput;
    [SerializeField] private InputField _levelInput;
    private string _name;
    private float _experience;
    private int _level;

    public void SavePlayerData()
    {
        _name = _nameInput.text;
        _experience = float.Parse(_experienceInput.text);
        _level = int.Parse(_levelInput.text);

        PlayerPrefs.SetString("Name", _name);
        PlayerPrefs.SetFloat("Experience", _experience);
        PlayerPrefs.SetInt("Level", _level);
        PlayerPrefs.Save();
    }

    public void LoadPlayerData()
    {
        _name = PlayerPrefs.GetString("Name");
        _experience = PlayerPrefs.GetFloat("Experience");
        _level = PlayerPrefs.GetInt("Level");

        _nameInput.text = _name;
        _experienceInput.text = _experience.ToString();
        _levelInput.text = _level.ToString();
    }

    public void QueryNameData()
    {
        if(PlayerPrefs.HasKey("Name"))
        {
            Debug.Log("PlayerPrefs has 'Name' key!");
            return;
        }
        Debug.Log("PlayerPrefs has no 'Name' key!");
    }

    public void DeleteNameData()
    {
        PlayerPrefs.DeleteKey("Name");
    }

    public void DeleteAllData()
    {
        PlayerPrefs.DeleteAll();
    }
}
