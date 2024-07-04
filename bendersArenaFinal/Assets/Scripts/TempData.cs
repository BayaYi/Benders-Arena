using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempData : MonoBehaviour
{
    
    public static TempData Instance;
    public int KuvvetBase;
    public int KuvvetZar;
    public int KuvvetBaseArtiZar;

    public int CeviklikBase;
    public int CeviklikZar;
    public int CevikeArtiZar;
    public int DayaniklilikBase;
    public int DayaniklilikZar;
    public int DayaniklilikBaseArtiZar;

    public int ZekaBase;
    public int ZekaZar;
    public int ZekaBaseArtiZar;
    public int FizikselBase;
    public int FizikselZar;
    public int FizikselBaseArtiZar;
    public int CiBase;
    public int CiZar;
    public int CiBaseArtiZar;

    public int KarizmaBase;
    public int KarizmaZar;
    public int KarizmaBaseArtiZar;
    public string Bukme;
    public int MaxValue;
    public string Isim;
    public bool _isRolledKuvvet;
    public bool _isRolledCeviklik;
    public bool _isRolledDayaniklilik;
    public bool _isRolledZeka;
    public bool _isRolledFiziksel;
    public bool _isRolledCi;
    public bool _isRolledKarizma;
    public void Awake()
    {
        // E�er ba�ka bir instance varsa bu instance'� yok et
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}
