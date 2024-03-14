using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtiCode : MonoBehaviour
{
    [SerializeField] private Text txtDisplayNumber;
    private int counter = 0;
    private const int MaxValue = 7; // Artırma ve azaltma sınırları

    // Start is called before the first frame update
    void Start()
    {
        DisplayTheNumber();
    }

    public void IncreaseAndDisplay()
    {
        if (counter < MaxValue) // Artırma sınırını kontrol et
        {
            IncreaseTheValueBy1();
            DisplayTheNumber();
        }
    }

    public void DecreaseAndDisplay()
    {
        if (counter > -MaxValue) // Azaltma sınırını kontrol et
        {
            DecreaseTheValueBy1();
            DisplayTheNumber();
        }
    }

    private void IncreaseTheValueBy1()
    {
        counter++;
    }

    private void DecreaseTheValueBy1()
    {
        counter--;
    }

    private void DisplayTheNumber()
    {
        txtDisplayNumber.text = counter.ToString();
    }
}
