using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceMechanics : MonoBehaviour
{
    public int DiceType = 0;
    public int DiceAmount = 0;
    public int[] dices = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //allDices(DiceType, DiceAmount);
        //DiceToConsole();
        //int[] statDiceResults = diceRollsForStats();
        //DiceToConsole(statDiceResults);

    }

    public int dice(int DiceType)//Istenilen Yuze Sahip Zar Donduren Class
    {
        int dice = UnityEngine.Random.Range(1, DiceType+1);
        return dice;
    }

    //Bir diziye istenilen türdeki zarýn istenilen sayýda atýp sonucunu döndüren method
    public int[] allDices(int DiceType,int DiceAmount)
    {
        dices = new int[DiceAmount];
        for (int i = 0;i < DiceAmount; i++)
        {
            dices[i] = dice(DiceType);
        }
        return dices;
    }

    public void DiceToConsole(int[] results) {
        Debug.Log(String.Join("/",
            new List<int>(results)
            .ConvertAll(i => i.ToString())
            .ToArray()));
    }

    public int WeightedAverage()
    {
        int result;
        int[] dizi = allDices(6, 4);
        Array.Sort(dizi);
        Array.Reverse(dizi);
        int total = dizi[0] + dizi[1] + dizi[2];
        double ortalama = total / 3.0;
        int asagiYuvarlama=(int) Math.Floor(ortalama);
        return result = asagiYuvarlama;
    }

    //public int[] diceRollsForStats()
    //{
    //    int[] distirubutableDiceResults = new int[7];
    //    for (int i = 0; i < 6; i++)
    //    {
    //        int[] dice = allDices(6, 4);
    //        Array.Sort(dice);
    //        int total = dice[1] + dice[2] + dice[3];
    //        double average = total / 3.0;
    //        int roundedDownAverage = (int)Math.Floor(average)+1;
    //        distirubutableDiceResults[i] = roundedDownAverage;
    //    }
    //    return distirubutableDiceResults;
    //}
}
