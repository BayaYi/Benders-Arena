using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZarCode : MonoBehaviour
{
    public Text diceResultText;
    public Text diceResultText1;
    public Text diceResultText2;
    public Text diceResultText3;
    public Text diceResultText4;
    public Text diceResultText5;
    public Text diceResultText6;

    private int[] lastRolledValues = new int[7]; // Zar değerlerini saklayan dizi
    private bool[] hasRolled = new bool[7]; // Zarların daha önce atılıp atılmadığını kontrol eden dizi

    void Start()
    {
        LoadData(); // Oyun başladığında kayıtlı zar sonuçlarını yükle
        DisplayLoadedData(); // Yüklenen zar sonuçlarını ekranda göster
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
            SaveData(); // Zar sonucunu kaydet
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
            PlayerPrefs.SetInt("LastRolledValue" + i, lastRolledValues[i]);
            PlayerPrefs.SetInt("HasRolled" + i, hasRolled[i] ? 1 : 0);
        }
        PlayerPrefs.Save();
    }

    // Kayıtlı verileri yüklemek için kullanılacak fonksiyon
    public void LoadData()
    {
        for (int i = 0; i < lastRolledValues.Length; i++)
        {
            if (PlayerPrefs.HasKey("LastRolledValue" + i))
            {
                lastRolledValues[i] = PlayerPrefs.GetInt("LastRolledValue" + i);
                hasRolled[i] = PlayerPrefs.GetInt("HasRolled" + i) == 1;
            }
        }
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
        for (int i = 0; i < lastRolledValues.Length; i++)
        {
            PlayerPrefs.DeleteKey("LastRolledValue" + i);
            PlayerPrefs.DeleteKey("HasRolled" + i);
        }
        PlayerPrefs.Save();
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
