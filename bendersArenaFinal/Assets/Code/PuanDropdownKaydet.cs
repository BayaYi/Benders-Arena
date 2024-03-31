using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuanDropdownKaydet : MonoBehaviour
{

    [SerializeField] private Dropdown _elementDropdown;

    private void Start()
    {
        // Kaydedilen indeksi PlayerPrefs'ten yükle
        int kaydedilenIndex = PlayerPrefs.GetInt("SecilenElementIndex", 0);
        _elementDropdown.value = kaydedilenIndex;
    }

    public void SecilenElementiKaydet()
    {
        // Seçilen indeksi PlayerPrefs ile kaydet
        int secilenIndex = _elementDropdown.value;
        PlayerPrefs.SetInt("SecilenElementIndex", secilenIndex);
        PlayerPrefs.Save();
    }
}


