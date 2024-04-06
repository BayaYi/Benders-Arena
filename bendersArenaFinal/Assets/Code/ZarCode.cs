using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZarCode : MonoBehaviour

{
    public Text diceResultText;// UI metin nesnesi
    public Text diceResultText1;
    public Text diceResultText2;
    public Text diceResultText3;
    public Text diceResultText4;
    public Text diceResultText5;
    public Text diceResultText6;
    private int lastRolledValue = 0;

    public void Start()
    {
        // Butona tıklanınca zarı atmak için butonun onClick eventini kullanalım
        // Bu örnekte butonun adı "RollButton" olsun
        GameObject rollButton = GameObject.Find("RollButton");
        rollButton.GetComponent<Button>().onClick.AddListener(RollDice);
    }

    public void RollDice()
    {
        // Rastgele bir sayı üretelim (1 ile 7 arasında)
        int rolledValue = Random.Range(1, 8);

        // Üretilen değeri UI metin nesnesine yazdıralım
        diceResultText.text = "" + rolledValue;

        // Son atılan değeri kaydedelim
        lastRolledValue = rolledValue;
    }

    // Bu fonksiyon son atılan zar değerini döndürür
    public int GetLastRolledValue()
    {
        return lastRolledValue;
    }
}




