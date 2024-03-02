using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceMechanics : MonoBehaviour
{
    public int[] dices = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        allDices(6,3);
        DiceToConsole();
        
    }

    public int dice(int DiceType)//Istenilen Yuze Sahip Zar Donduren Class
    {
        int dice = UnityEngine.Random.Range(1, DiceType);
        return dice;
    }


    public void allDices(int DiceType,int DiceAmount)
    {
        
        for(int i = 0;i < DiceAmount; i++)
        {
            dices[i] = dice(DiceType);
        }
    }

    public void DiceToConsole() {
        Debug.Log(String.Join("/",
            new List<int>(dices)
            .ConvertAll(i => i.ToString())
            .ToArray()));
    }
}
