using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArttirmaCode : MonoBehaviour
{
    public TempData tempData;
    [SerializeField] private Text txtDisplayNumber2;
    [SerializeField] private Text txtDisplayNumber3;
    [SerializeField] private Text txtDisplayNumber4;
    [SerializeField] private Text txtDisplayNumber5;
    [SerializeField] private Text txtDisplayNumber6;
    [SerializeField] private Text txtDisplayNumber7;
    [SerializeField] private Text txtDisplayNumber8;

    private int counter3 = 0;
    private int counter4 = 0;
    private int counter5 = 0;
    private int counter6 = 0;
    private int counter7 = 0;
    private int counter8 = 0;
    private int counter9 = 0;
    private int MaxValue = 0; // Artırma ve azaltma sınırları

    void Start()
    {
        LoadCounters(); // Kaydedilen değerleri yükle
        DisplayTheNumbers();
    }

    private void LateUpdate()
    {
        tempData.KuvvetBase = counter3;// PlayerPrefs.GetInt("Counter3", 0);
        tempData.CeviklikBase = counter4;// PlayerPrefs.GetInt("Counter4", 0);
        tempData.DayaniklilikBase = counter5;// PlayerPrefs.GetInt("Counter5", 0);
        tempData.ZekaBase = counter6;// PlayerPrefs.GetInt("Counter6", 0);
        tempData.FizikselBase = counter7;// PlayerPrefs.GetInt("Counter7", 0);
        tempData.CiBase = counter8;// PlayerPrefs.GetInt("Counter8", 0);
        tempData.KarizmaBase = counter9;// PlayerPrefs.GetInt("Counter9", 0);
        DisplayTheNumbers();
    }

    public void IncreaseAndDisplay2()
    {
        if (MaxValue < 7)
        {
            IncreaseTheValueBy1(ref counter3);
            MaxValue++;
            //SaveCounters();
            
             // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay3()
    {
        if (MaxValue < 7)
        {
            IncreaseTheValueBy1(ref counter4);
            MaxValue++;
            //DisplayTheNumbers();
            //SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay4()
    {
        if (MaxValue < 7)
        {
            IncreaseTheValueBy1(ref counter5);
            MaxValue++;
            //DisplayTheNumbers();
            //SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay5()
    {
        if (MaxValue < 7)
        {
            IncreaseTheValueBy1(ref counter6);
            MaxValue++;
            //DisplayTheNumbers();
            //SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay6()
    {
        if (MaxValue < 7)
        {
            IncreaseTheValueBy1(ref counter7);
            MaxValue++;
            //DisplayTheNumbers();
            //SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay7()
    {
        if (MaxValue < 7)
        {
            IncreaseTheValueBy1(ref counter8);
            MaxValue++;
            //DisplayTheNumbers();
            //SaveCounters(); // Değişiklikleri kaydet
        }
    }

    public void IncreaseAndDisplay8()
    {
        if (MaxValue < 7)
        {
            IncreaseTheValueBy1(ref counter9);
            MaxValue++;
            //DisplayTheNumbers();
            //SaveCounters(); // Değişiklikleri kaydet
        }
    }

    private void IncreaseTheValueBy1(ref int value)
    {
        value++;
    }

    private void DisplayTheNumbers()
    {
        txtDisplayNumber2.text = tempData.KuvvetBase.ToString();
        txtDisplayNumber3.text = tempData.CeviklikBase.ToString();
        txtDisplayNumber4.text = tempData.DayaniklilikBase.ToString();
        txtDisplayNumber5.text = tempData.ZekaBase.ToString();
        txtDisplayNumber6.text = tempData.FizikselBase.ToString();
        txtDisplayNumber7.text = tempData.CiBase.ToString();
        txtDisplayNumber8.text = tempData.KarizmaBase.ToString();
    }

    private void SaveCounters()
    {

        PlayerPrefs.SetInt("Counter3", counter3);
        PlayerPrefs.SetInt("Counter4", counter4);
        PlayerPrefs.SetInt("Counter5", counter5);
        PlayerPrefs.SetInt("Counter6", counter6);
        PlayerPrefs.SetInt("Counter7", counter7);
        PlayerPrefs.SetInt("Counter8", counter8);
        PlayerPrefs.SetInt("Counter9", counter9);
        PlayerPrefs.SetInt("MaxValue", MaxValue);
        PlayerPrefs.Save();
        
    }

    private void LoadCounters()
    {
        /*tempData.KuvvetBase = counter3;// PlayerPrefs.GetInt("Counter3", 0);
        tempData.CeviklikBase = counter4;// PlayerPrefs.GetInt("Counter4", 0);
        tempData.DayaniklilikBase = counter5;// PlayerPrefs.GetInt("Counter5", 0);
        tempData.ZekaBase = counter6;// PlayerPrefs.GetInt("Counter6", 0);
        tempData.FizikselBase = counter7;// PlayerPrefs.GetInt("Counter7", 0);
        tempData.CiBase = counter8;// PlayerPrefs.GetInt("Counter8", 0);
        tempData.KarizmaBase = counter9;*/// PlayerPrefs.GetInt("Counter9", 0);
        MaxValue = tempData.MaxValue;
        counter3 = tempData.KuvvetBase;
        counter4 = tempData.CeviklikBase;
        counter5 = tempData.DayaniklilikBase;
        counter6 = tempData.ZekaBase;
        counter7 = tempData.FizikselBase;
        counter8 = tempData.CiBase;
        counter9 = tempData.KarizmaBase;
        //MaxValue = PlayerPrefs.GetInt("MaxValue", 7);
        /*counter3 = PlayerPrefs.GetInt("Counter3", 0);
        counter4 = PlayerPrefs.GetInt("Counter4", 0);
        counter5 = PlayerPrefs.GetInt("Counter5", 0);
        counter6 = PlayerPrefs.GetInt("Counter6", 0);
        counter7 = PlayerPrefs.GetInt("Counter7", 0);
        counter8 = PlayerPrefs.GetInt("Counter8", 0);
        counter9 = PlayerPrefs.GetInt("Counter9", 0);
        MaxValue = PlayerPrefs.GetInt("MaxValue", 7);

        /*tempData.KuvvetBase = PlayerPrefs.GetInt("Counter3", 0);
        tempData.CeviklikBase = PlayerPrefs.GetInt("Counter4", 0);
        tempData.DayaniklilikBase = PlayerPrefs.GetInt("Counter5", 0);
        tempData.ZekaBase = PlayerPrefs.GetInt("Counter6", 0);
        tempData.FizikselBase = PlayerPrefs.GetInt("Counter7", 0);
        tempData.CiBase = PlayerPrefs.GetInt("Counter8", 0);
        tempData.KarizmaBase = PlayerPrefs.GetInt("Counter9", 0);
        */

    }



    public void DeleteAllData()
    {
        PlayerPrefs.DeleteAll();
        counter3 = 0;
        counter4 = 0;
        counter5 = 0;
        counter6 = 0;
        counter7 = 0;
        counter8 = 0;
        counter9 = 0;
        MaxValue = 7;
        DisplayTheNumbers();
    }
}
