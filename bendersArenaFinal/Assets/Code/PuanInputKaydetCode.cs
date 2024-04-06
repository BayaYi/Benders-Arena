using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuanInputKaydetCode : MonoBehaviour
{

    [SerializeField] private InputField _name1Input;
    [SerializeField] private Text _kalanHakText;

    private string _name1;
    private string _kalanHak;


    public void SavePlayerData()
    {
        _name1 = _name1Input.text;
        _kalanHak = _kalanHakText.text;


        PlayerPrefs.SetString("Name", _name1);
        PlayerPrefs.SetString("KalanHak", _kalanHak);

        PlayerPrefs.Save();
    }


public void DeleteAllData()
    {
        PlayerPrefs.DeleteAll();
    }


}


