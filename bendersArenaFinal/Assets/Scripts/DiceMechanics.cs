using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceMechanics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int dice(int DiceType)//Istenilen Yuze Sahip Zar Donduren Class
    {
        int dice = Random.Range(0, DiceType);
        return dice;
    }


    public int[] allDices(int DiceType,int DiceAmount)
    {
        int[] allDices = null;
        for(int i = 0;i < DiceAmount; i++)
        {
            allDices[i] = dice(DiceType);
        }
        return allDices[DiceAmount];
    }
}
