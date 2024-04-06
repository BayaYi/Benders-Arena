using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuanInputKaydetCode : MonoBehaviour
{

    [SerializeField] private InputField _name1Input;
    [SerializeField] private Text _kalanHakText;
    [SerializeField] private Text txtDisplayNumber2;
    [SerializeField] private Text txtDisplayNumber3;
    [SerializeField] private Text txtDisplayNumber4;
    [SerializeField] private Text txtDisplayNumber5;
    [SerializeField] private Text txtDisplayNumber6;
    [SerializeField] private Text txtDisplayNumber7;
    [SerializeField]  Text txtDisplayNumber8;

    private string _name1;
    private string _kalanHak;
    private string txtDisplay2;
    private string txtDisplay3;
    private string txtDisplay4;
    private string txtDisplay5;
    private string txtDisplay6;
    private string txtDisplay7;
    private string txtDisplay8;

    public void SavePlayerData()
    {
        _name1 = _name1Input.text;
        _kalanHak = _kalanHakText.text;

        txtDisplay2 = txtDisplayNumber2.text;
        txtDisplay3 = txtDisplayNumber3.text;
        txtDisplay4 = txtDisplayNumber4.text;
        txtDisplay5 = txtDisplayNumber5.text;
        txtDisplay6 = txtDisplayNumber6.text;
        txtDisplay7 = txtDisplayNumber7.text;
        txtDisplay8 = txtDisplayNumber8.text;




        PlayerPrefs.SetString("Name", _name1);
        PlayerPrefs.SetString("KalanHak", _kalanHak);
        PlayerPrefs.SetString("Display1", txtDisplay2);
        PlayerPrefs.SetString("Display2", txtDisplay3);
        PlayerPrefs.SetString("Display3", txtDisplay4);
        PlayerPrefs.SetString("Display4", txtDisplay5);
        PlayerPrefs.SetString("Display5", txtDisplay6);
        PlayerPrefs.SetString("Display6", txtDisplay7);
        PlayerPrefs.SetString("Display7", txtDisplay8);


        PlayerPrefs.Save();
    }


public void DeleteAllData()
    {
        PlayerPrefs.DeleteAll();
    }



}


