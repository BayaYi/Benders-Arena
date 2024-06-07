using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZarToprakCode : MonoBehaviour





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

        public Text totalHealthText;
    public Text totalPhysicalEnergyText;
    public Text totalChiEnergyText;
    public Text totalSpeedText;
    public Text totalPhysicalDefenceText;
    public Text totalBendingDefenceText;
    public Text totalInitiativeText;

    void Start()
    {
        // Kaydedilmiş puanları yükleme
        LoadScores();
    }
/*public void CalculateTotalScore(Text txtDisplayNumber, Text diceResultText, Text totalScoreText)
    {
        int totalScore = CalculateIndividualTotalScore(txtDisplayNumber, diceResultText);
        totalScoreText.text = totalScore.ToString();
        SaveScore(totalScoreText.name, totalScore);

        CalculateNewTotals();
    }*/
    public void CalculateTotalScore()
    {
        int totalScore = CalculateIndividualTotalScore(txtDisplayNumber2, diceResultText);
        totalScoreText.text = totalScore.ToString();
        SaveScore("totalScore", totalScore);
         CalculateNewTotals2();
    }

    public void CalculateTotalScore1()
    {
        int totalScore = CalculateIndividualTotalScore(txtDisplayNumber3, diceResultText1);
        totalScoreText1.text = totalScore.ToString();
        SaveScore("totalScore1", totalScore);
    }

    public void CalculateTotalScore2()
    {
        int totalScore = CalculateIndividualTotalScore(txtDisplayNumber4, diceResultText2);
        totalScoreText2.text = totalScore.ToString();
        SaveScore("totalScore2", totalScore);
    }

    public void CalculateTotalScore3()
    {
        int totalScore = CalculateIndividualTotalScore(txtDisplayNumber5, diceResultText3);
        totalScoreText3.text = totalScore.ToString();
        SaveScore("totalScore3", totalScore);
    }

    public void CalculateTotalScore4()
    {
        int totalScore = CalculateIndividualTotalScore(txtDisplayNumber6, diceResultText4);
        totalScoreText4.text = totalScore.ToString();
        SaveScore("totalScore4", totalScore);
    }

    public void CalculateTotalScore5()
    {
        int totalScore = CalculateIndividualTotalScore(txtDisplayNumber7, diceResultText5);
        totalScoreText5.text = totalScore.ToString();
        SaveScore("totalScore5", totalScore);
    }

    public void CalculateTotalScore6()
    {
        int totalScore = CalculateIndividualTotalScore(txtDisplayNumber8, diceResultText6);
        totalScoreText6.text = totalScore.ToString();
        SaveScore("totalScore6", totalScore);
    }

    int CalculateIndividualTotalScore(Text txtDisplayNumber, Text diceResultText)
    {
        int score1 = int.Parse(txtDisplayNumber.text);
        int score2 = int.Parse(diceResultText.text);
        return score1 + score2;
    }

    public void SaveScore(string key, int score)
    {
        PlayerPrefs.SetInt(key, score);
    }

    public void LoadScores()
    {
        totalScoreText.text = PlayerPrefs.GetInt("totalScore", 0).ToString();
        totalScoreText1.text = PlayerPrefs.GetInt("totalScore1", 0).ToString();
        totalScoreText2.text = PlayerPrefs.GetInt("totalScore2", 0).ToString();
        totalScoreText3.text = PlayerPrefs.GetInt("totalScore3", 0).ToString();
        totalScoreText4.text = PlayerPrefs.GetInt("totalScore4", 0).ToString();
        totalScoreText5.text = PlayerPrefs.GetInt("totalScore5", 0).ToString();
        totalScoreText6.text = PlayerPrefs.GetInt("totalScore6", 0).ToString();

        CalculateNewTotals2();
    }
     public void CalculateNewTotals2()
    {
        totalHealthText.text = (20 + (8 * int.Parse(totalScoreText2.text))).ToString();
        totalPhysicalEnergyText.text = (int.Parse(totalScoreText2.text) + int.Parse(totalScoreText4.text)).ToString();
        totalChiEnergyText.text = totalScoreText5.text;
        totalSpeedText.text = (int.Parse(totalScoreText1.text) + 2).ToString();
        totalPhysicalDefenceText.text = (int.Parse(totalScoreText1.text) + 10).ToString();
        totalBendingDefenceText.text = (int.Parse(totalPhysicalDefenceText.text) + int.Parse(totalScoreText5.text)).ToString();
        totalInitiativeText.text = (int.Parse(totalScoreText1.text) + int.Parse(totalScoreText3.text)).ToString();
    }

    public void DeleteSavedScore(string key)
    {
        PlayerPrefs.DeleteKey(key);
    }
}



