using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puanTextGösterCode : MonoBehaviour

{
    [SerializeField] private Text _name1Text;

    private string _name1;

    public void Start()
    {
        // İlk sahnede veriyi kaydetmiş varsayalım
        // Bu verileri burada alıyoruz:
        _name1 = PlayerPrefs.GetString("Name");



        // UI elemanlarını güncelle
        _name1Text.text = "Ad: " + _name1;


    }

    [SerializeField] private Text _kalanHakText;
    private int _kalanHak = 7;

    public void Start1()
    {
        // Başlangıçta kalan hakkı ekrana yazdır
        _kalanHakText.text = _kalanHak.ToString();
    }

    public void ArttirmaButonunaTiklandi(int artisMiktari)
    {
        // Arttırma butonlarından birine tıklandığında çalışır
        _kalanHak -= artisMiktari;

        // Negatif değerleri engelle
        _kalanHak = Mathf.Max(_kalanHak, 0);

        // Yeni kalan hakkı ekrana yazdır
        _kalanHakText.text = _kalanHak.ToString();
    }




}



