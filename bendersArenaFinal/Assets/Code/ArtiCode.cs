using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtiCode : MonoBehaviour
{
    [SerializeField] private Text txtDisplayNumber;
    [SerializeField] private Text txtDisplayNumber1;
    private int counter1 = 0;
    private int counter2 = 0;
    private const int MaxValue = 7; // Artırma ve azaltma sınırları

    // Start is called before the first frame update
    void Start()
    {
        DisplayTheNumbers();
    }

    public void IncreaseAndDisplay1()
    {
        if (counter1 < MaxValue) // Artırma sınırını kontrol et
        {
            IncreaseTheValueBy1(ref counter1);
            DisplayTheNumbers();
        }
    }

    public void DecreaseAndDisplay1()
    {
        if (counter1 > -MaxValue) // Azaltma sınırını kontrol et
        {
            DecreaseTheValueBy1(ref counter1);
            DisplayTheNumbers();
        }
    }

    public void IncreaseAndDisplay2()
    {
        if (counter2 < MaxValue) // Artırma sınırını kontrol et
        {
            IncreaseTheValueBy1(ref counter2);
            DisplayTheNumbers();
        }
    }

    public void DecreaseAndDisplay2()
    {
        if (counter2 > -MaxValue) // Azaltma sınırını kontrol et
        {
            DecreaseTheValueBy1(ref counter2);
            DisplayTheNumbers();
        }
    }

    private void IncreaseTheValueBy1(ref int value)
    {
        value++;
    }

    private void DecreaseTheValueBy1(ref int value)
    {
        value--;
    }

    private void DisplayTheNumbers()
    {
        txtDisplayNumber.text = counter1.ToString();
        txtDisplayNumber1.text = counter2.ToString();
    }
}
