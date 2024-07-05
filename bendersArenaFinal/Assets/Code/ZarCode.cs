using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZarCode : MonoBehaviour
{
    public TempData tempData;



    public Text diceResultText;
    public Text diceResultText1;
    public Text diceResultText2;
    public Text diceResultText3;
    public Text diceResultText4;
    public Text diceResultText5;
    public Text diceResultText6;

    private int[] lastRolledValues = new int[7]; // Zar değerlerini saklayan dizi
    private bool[] hasRolled = new bool[7]; // Zarların daha önce atılıp atılmadığını kontrol eden dizi

    public GameObject _gameObject, _playerControl;
    PlayerControl _control;
    void Start()
    {
        _playerControl = GameObject.Find("PlayerControl");
        _control = _playerControl.GetComponent<PlayerControl>();
        _gameObject = GameObject.Find($"TempData{_control._playerNumber}");
        tempData = _gameObject.GetComponent<TempData>();


        LoadData(); // Oyun başladığında kayıtlı zar sonuçlarını yükle
        DisplayLoadedData(); // Yüklenen zar sonuçlarını ekranda göster
    }

    private void LateUpdate()
    {
        
        tempData._isRolledKuvvet = hasRolled[0];
        tempData._isRolledCeviklik = hasRolled[1];
        tempData._isRolledDayaniklilik = hasRolled[2];
        tempData._isRolledZeka = hasRolled[3];
        tempData._isRolledFiziksel = hasRolled[4];
        tempData._isRolledCi = hasRolled[5];
        tempData._isRolledKarizma = hasRolled[6];
        tempData.KuvvetZar = lastRolledValues[0]; 
        tempData.CeviklikZar = lastRolledValues[1]; 
        tempData.DayaniklilikZar = lastRolledValues[2]; 
        tempData.ZekaZar = lastRolledValues[3];
        tempData.FizikselZar = lastRolledValues[4];
        tempData.CiZar = lastRolledValues[5];
        tempData.KarizmaZar = lastRolledValues[6];
        DisplayLoadedData();
    }

    // Zar atma fonksiyonları
    public void RollDice(Text diceResultText, int index)
    {
        if (!hasRolled[index])
        {
            int rolledValue = Random.Range(1, 7);
            diceResultText.text = rolledValue.ToString();
            lastRolledValues[index] = rolledValue; // Zar sonucunu sakla
            hasRolled[index] = true; // Zarın atıldığını işaretle
            //SaveData(); // Zar sonucunu kaydet
        }
    }

    // Zar atma butonları için çağrılacak fonksiyonlar
    public void OnRollButtonClicked()
    {
        RollDice(diceResultText, 0);
    }

    public void OnRollButton1Clicked()
    {
        RollDice(diceResultText1, 1);
    }

    public void OnRollButton2Clicked()
    {
        RollDice(diceResultText2, 2);
    }

    public void OnRollButton3Clicked()
    {
        RollDice(diceResultText3, 3);
    }

    public void OnRollButton4Clicked()
    {
        RollDice(diceResultText4, 4);
    }

    public void OnRollButton5Clicked()
    {
        RollDice(diceResultText5, 5);
    }

    public void OnRollButton6Clicked()
    {
        RollDice(diceResultText6, 6);
    }

    // Verileri kaydetmek için kullanılacak fonksiyon
    public void SaveData()
    {
        for (int i = 0; i < lastRolledValues.Length; i++)
        {
            //PlayerPrefs.SetInt("LastRolledValue" + i, lastRolledValues[i]);
            //PlayerPrefs.SetInt("HasRolled" + i, hasRolled[i] ? 1 : 0);
            //tempData._isRolled[i] = hasRolled[i];
        }



        //PlayerPrefs.Save();

        /*tempData.KuvvetZar = lastRolledValues[0]; //PlayerPrefs.GetInt("diceResultText", 0);
        tempData.CeviklikZar = lastRolledValues[1]; //PlayerPrefs.GetInt("diceResultText1", 0);
        tempData.DayaniklilikZar = lastRolledValues[2]; //PlayerPrefs.GetInt("diceResultText2", 0);
        tempData.ZekaZar = lastRolledValues[3]; //PlayerPrefs.GetInt("diceResultText3", 0);
        tempData.FizikselZar = lastRolledValues[4];//PlayerPrefs.GetInt("diceResultText4", 0);
        tempData.CiZar = lastRolledValues[5];// PlayerPrefs.GetInt("diceResultText5", 0);
        tempData.KarizmaZar = lastRolledValues[6];// PlayerPrefs.GetInt("diceResultText6", 0);*/
    }

    // Kayıtlı verileri yüklemek için kullanılacak fonksiyon
    public void LoadData()
    {
        hasRolled[0] = tempData._isRolledKuvvet;
        hasRolled[1] = tempData._isRolledCeviklik;
        hasRolled[2] = tempData._isRolledDayaniklilik;
        hasRolled[3] = tempData._isRolledZeka;
        hasRolled[4] = tempData._isRolledFiziksel;
        hasRolled[5] = tempData._isRolledCi;
        hasRolled[6] = tempData._isRolledKarizma;

        
        lastRolledValues[0] = tempData.KuvvetZar;
        lastRolledValues[1] = tempData.CeviklikZar;
        lastRolledValues[2] = tempData.DayaniklilikZar;
        lastRolledValues[3] = tempData.ZekaZar;
        lastRolledValues[4] = tempData.FizikselZar;
        lastRolledValues[5] = tempData.CiZar;
        lastRolledValues[6] = tempData.KarizmaZar;
        /*for (int i = 0; i < lastRolledValues.Length; i++)
        {
            if (PlayerPrefs.HasKey("LastRolledValue" + i))
            {
                lastRolledValues[i] = PlayerPrefs.GetInt("LastRolledValue" + i);
                hasRolled[i] = PlayerPrefs.GetInt("HasRolled" + i) == 1;
            }
        }*/


    }

    // Yüklenen verileri ekranda gösterme fonksiyonu
    private void DisplayLoadedData()
    {
        for (int i = 0; i < lastRolledValues.Length; i++)
        {
            switch (i)
            {
                case 0:
                    diceResultText.text = lastRolledValues[i].ToString();
                    break;
                case 1:
                    diceResultText1.text = lastRolledValues[i].ToString();
                    break;
                case 2:
                    diceResultText2.text = lastRolledValues[i].ToString();
                    break;
                case 3:
                    diceResultText3.text = lastRolledValues[i].ToString();
                    break;
                case 4:
                    diceResultText4.text = lastRolledValues[i].ToString();
                    break;
                case 5:
                    diceResultText5.text = lastRolledValues[i].ToString();
                    break;
                case 6:
                    diceResultText6.text = lastRolledValues[i].ToString();
                    break;
            }
        }
    }

    // Kayıtlı verileri silmek için kullanılacak fonksiyon
    public void DeleteData()
    {
        tempData._isRolledKuvvet = false;
        tempData._isRolledCeviklik = false;
        tempData._isRolledDayaniklilik = false;
        tempData._isRolledZeka = false;
        tempData._isRolledFiziksel = false;
        tempData._isRolledCi = false;
        tempData._isRolledKarizma = false;
        tempData.KuvvetZar = 0;
        tempData.CeviklikZar = 0;
        tempData.DayaniklilikZar = 0;
        tempData.ZekaZar = 0;
        tempData.FizikselZar = 0;
        tempData.CiZar = 0;
        tempData.KarizmaZar = 0;
        ResetValues(); // Verileri sıfırla
    }

    // Verileri sıfırlama fonksiyonu
    private void ResetValues()
    {
        for (int i = 0; i < lastRolledValues.Length; i++)
        {
            lastRolledValues[i] = 0;
            hasRolled[i] = false;
        }

        diceResultText.text = "";
        diceResultText1.text = "";
        diceResultText2.text = "";
        diceResultText3.text = "";
        diceResultText4.text = "";
        diceResultText5.text = "";
        diceResultText6.text = "";
    }
}
