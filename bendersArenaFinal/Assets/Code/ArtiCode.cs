using UnityEngine;
using UnityEngine.UI;

public class ArtiCode : MonoBehaviour
{
    [SerializeField] private Text txtDisplayNumber;
    [SerializeField] private Text txtDisplayNumber1;
    private int counter1 = 0;
    private int counter2 = 0;
    private const int MaxValue = 7; // Artırma ve azaltma sınırları

    void Start()
    {
        LoadCounters(); // Kaydedilen değerleri yükle
        DisplayTheNumbers();
    }

    public void IncreaseAndDisplay1()
    {
        if (counter1 < MaxValue)
        {
            IncreaseTheValueBy1(ref counter1);
            DisplayTheNumbers();
            SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void DecreaseAndDisplay1()
    {
        if (counter1 > -MaxValue)
        {
            DecreaseTheValueBy1(ref counter1);
            DisplayTheNumbers();
            SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay2()
    {
        if (counter2 < MaxValue)
        {
            IncreaseTheValueBy1(ref counter2);
            DisplayTheNumbers();
            SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void DecreaseAndDisplay2()
    {
        if (counter2 > -MaxValue)
        {
            DecreaseTheValueBy1(ref counter2);
            DisplayTheNumbers();
            SaveCounters(); // Değişiklikleri kaydet
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

    private void SaveCounters()
    {
        PlayerPrefs.SetInt("Counter1", counter1);
        PlayerPrefs.SetInt("Counter2", counter2);
        PlayerPrefs.Save();
    }

    private void LoadCounters()
    {
        counter1 = PlayerPrefs.GetInt("Counter1", 0);
        counter2 = PlayerPrefs.GetInt("Counter2", 0);
    }

    public void DeleteAllData()
    {
        PlayerPrefs.DeleteAll();
        counter1 = 0;
        counter2 = 0;
        DisplayTheNumbers();
    }
}
