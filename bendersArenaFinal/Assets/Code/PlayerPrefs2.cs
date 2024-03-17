using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefs2 : MonoBehaviour
{
    [SerializeField] private Text _nameText;
    [SerializeField] private Text _experienceText;
    [SerializeField] private Text _levelText;


    private string _name;
    private float _experience;
    private int _level;


    private void Start()
    {
        // İlk sahnede veriyi kaydetmiş varsayalım
        // Bu verileri burada alıyoruz:
        _name = PlayerPrefs.GetString("Name");
        _experience = PlayerPrefs.GetFloat("Experience");
        _level = PlayerPrefs.GetInt("Level");

        // UI elemanlarını güncelle
        _nameText.text = "Ad: " + _name;
        _experienceText.text = "Deneyim: " + _experience.ToString();
        _levelText.text = "Seviye: " + _level.ToString();
    }
}

