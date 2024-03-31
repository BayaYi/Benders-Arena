using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puanTextGösterCode : MonoBehaviour

{
    [SerializeField] private Text _name1Text;





    private string _name1;




    private void Start()
    {
        // İlk sahnede veriyi kaydetmiş varsayalım
        // Bu verileri burada alıyoruz:
        _name1 = PlayerPrefs.GetString("Name");



        // UI elemanlarını güncelle
        _name1Text.text = "Ad: " + _name1;


    }
}

