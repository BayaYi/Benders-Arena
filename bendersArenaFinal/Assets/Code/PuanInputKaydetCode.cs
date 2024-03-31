using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuanInputKaydetCode : MonoBehaviour
{

    [SerializeField] private InputField _name1Input;
    [SerializeField] private Dropdown _elementDropdown;

    private string _name1;
    private string _element;

    public void SavePlayerData()
    {
        _name1 = _name1Input.text;
       _element = _elementDropdown.options[_elementDropdown.value].text;




        PlayerPrefs.SetString("Name", _name1);
        PlayerPrefs.SetString("Element", _element);

        PlayerPrefs.Save();
    }


public void DeleteAllData()
    {
        PlayerPrefs.DeleteAll();
    }



}


