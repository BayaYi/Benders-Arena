using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zarArtiToplamCode : MonoBehaviour
{

    public Text txtDisplayNumber2;
    public Text txtDisplayNumber3;
    public Text txtDisplayNumber4;
    public Text txtDisplayNumber5;
    public Text txtDisplayNumber6;
    public Text txtDisplayNumber7;
    public Text txtDisplayNumber8;
    public Text diceResultText;
    public Text diceResultText1;
    public Text diceResultText2;
    public Text diceResultText3;
    public Text diceResultText4;
    public Text diceResultText5;
    public Text diceResultText6;
    public Text totalScoreText;
    public Text totalScoreText1;
    public Text totalScoreText2;
    public Text totalScoreText3;
    public Text totalScoreText4;
    public Text totalScoreText5;
    public Text totalScoreText6;

    public void CalculateTotalScore()
    {
        // İlk metin alanından puan değerini alıp int'e çevirme
        int score1 = int.Parse(txtDisplayNumber2.text);

        // İkinci metin alanından puan değerini alıp int'e çevirme
        int score2 = int.Parse(diceResultText.text);

        // Toplam puanı hesaplama
        int totalScore = score1 + score2;

        // Toplam puanı başka bir metin alanına yazdırma
        totalScoreText.text = totalScore.ToString();
    }
    public void CalculateTotalScore1()
    {
        // İlk metin alanından puan değerini alıp int'e çevirme
        int score1 = int.Parse(txtDisplayNumber3.text);

        // İkinci metin alanından puan değerini alıp int'e çevirme
        int score2 = int.Parse(diceResultText1.text);

        // Toplam puanı hesaplama
        int totalScore = score1 + score2;

        // Toplam puanı başka bir metin alanına yazdırma
        totalScoreText1.text = totalScore.ToString();
    }

    public void CalculateTotalScore2()
    {
        // İlk metin alanından puan değerini alıp int'e çevirme
        int score1 = int.Parse(txtDisplayNumber4.text);

        // İkinci metin alanından puan değerini alıp int'e çevirme
        int score2 = int.Parse(diceResultText2.text);

        // Toplam puanı hesaplama
        int totalScore = score1 + score2;

        // Toplam puanı başka bir metin alanına yazdırma
        totalScoreText2.text = totalScore.ToString();
    }

    public void CalculateTotalScore3()
    {
        // İlk metin alanından puan değerini alıp int'e çevirme
        int score1 = int.Parse(txtDisplayNumber5.text);

        // İkinci metin alanından puan değerini alıp int'e çevirme
        int score2 = int.Parse(diceResultText3.text);

        // Toplam puanı hesaplama
        int totalScore = score1 + score2;

        // Toplam puanı başka bir metin alanına yazdırma
        totalScoreText3.text = totalScore.ToString();
    }

    public void CalculateTotalScore4()
    {
        // İlk metin alanından puan değerini alıp int'e çevirme
        int score1 = int.Parse(txtDisplayNumber6.text);

        // İkinci metin alanından puan değerini alıp int'e çevirme
        int score2 = int.Parse(diceResultText4.text);

        // Toplam puanı hesaplama
        int totalScore = score1 + score2;

        // Toplam puanı başka bir metin alanına yazdırma
        totalScoreText4.text = totalScore.ToString();
    }
    public void CalculateTotalScore5()
    {
        // İlk metin alanından puan değerini alıp int'e çevirme
        int score1 = int.Parse(txtDisplayNumber7.text);

        // İkinci metin alanından puan değerini alıp int'e çevirme
        int score2 = int.Parse(diceResultText5.text);

        // Toplam puanı hesaplama
        int totalScore = score1 + score2;

        // Toplam puanı başka bir metin alanına yazdırma
        totalScoreText5.text = totalScore.ToString();
    }
    public void CalculateTotalScore6()
    {
        // İlk metin alanından puan değerini alıp int'e çevirme
        int score1 = int.Parse(txtDisplayNumber8.text);

        // İkinci metin alanından puan değerini alıp int'e çevirme
        int score2 = int.Parse(diceResultText6.text);

        // Toplam puanı hesaplama
        int totalScore = score1 + score2;

        // Toplam puanı başka bir metin alanına yazdırma
        totalScoreText6.text = totalScore.ToString();
    }


}


