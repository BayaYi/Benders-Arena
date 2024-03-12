using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtiCode : MonoBehaviour
{
    [SerializeField] private Text txtDisplayNumber;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        DisplayTheNumber();
    }

    public void IncreaseAndDisplay()
    {
        IncreaseTheValueBy1();
        DisplayTheNumber();
    }

    private void IncreaseTheValueBy1()
    {
        counter++;
    }

    private void DisplayTheNumber()
    {
        txtDisplayNumber.text = counter.ToString();
    }
}
