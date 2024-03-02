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
        Debug.Log(ShowDice(6));//Show Random Dice Numbers
    }

    public int ShowDice(int DiceType)
    {
        int randomDice = Random.Range(0, DiceType);
        return randomDice;
    }

}
