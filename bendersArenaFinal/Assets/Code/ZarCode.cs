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
    private int[] lastRolledValues = new int[7]; // Diziyi 6 elemanlı yapmalısınız

    void Start()
    {
        LoadData(); // Oyun başladığında kayıtlı zar sonuçlarını yükle
    }

    // Zar atma fonksiyonları
    public void RollDice(Text diceResultText, int index)
    {
        int rolledValue = Random.Range(1, 7);
        diceResultText.text = rolledValue.ToString();
        lastRolledValues[index] = rolledValue; // Zar sonucunu sakla
        SaveData(); // Zar sonucunu kaydet
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
                // Ekranda gösterme işlemi burada yapılmalı
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
    }

    // Kayıtlı verileri silmek için kullanılacak fonksiyon
    public void DeleteData()
    {
        for (int i = 0; i < lastRolledValues.Length; i++)
        {
            PlayerPrefs.DeleteKey("LastRolledValue" + i);
        }
        PlayerPrefs.Save();
    }
}
