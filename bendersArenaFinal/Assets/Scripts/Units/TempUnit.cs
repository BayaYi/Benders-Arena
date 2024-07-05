using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempUnit : BaseUnit
{
    public TempData tempData;
    public static TempUnit Instance;
    public zarAirCode zarAirCode;
    public zarFireCode zarFireCode;
    public zarWaterCode zarWaterCode;
    public ZarToprakCode zarToprakCode;
    public GameObject _gameObject, _playerControl;
    public GameObject _elementCheck;
    public PlayerControl _control;
    void Start()
    {
        _playerControl = GameObject.Find("PlayerControl");
        _control = _playerControl.GetComponent<PlayerControl>();
        


    }

    public void GetTempData()
    {
        _gameObject = GameObject.Find($"TempData{_control._playerNumber}");
        tempData = _gameObject.GetComponent<TempData>();

    }

    public void GetElementData()
    {
        _elementCheck = GameObject.Find("ElementControl");
    }

    public void Awake()
    {
        Instance = this;
        // E�er ba�ka bir instance varsa bu instance'� yok et
        /*if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }*/
    }
    // Start is called before the first frame update

    public void LateUpdate()
    {
        if ( _elementCheck != null )
        {
            if (tempData.Bukme == "Ates")
            {
                zarFireCode = _elementCheck.GetComponent <zarFireCode>();
            }
            if(tempData.Bukme == "Su")
            {
                zarWaterCode = _elementCheck.GetComponent<zarWaterCode>();
            }
            if( tempData.Bukme == "Toprak")
            {
                zarToprakCode = _elementCheck.GetComponent<ZarToprakCode>();
            }
            if(tempData.Bukme == "Hava")
            {
                zarAirCode = _elementCheck.GetComponent<zarAirCode>();
            }

        }


        
        if (zarToprakCode != null)
        {

            UnitName = tempData.Isim;
            Health = tempData._maxHealth;
            Stamina = tempData._physicalEnergy;
            Chi = tempData._chiEnergy;
            Speed = tempData._speed;
            PhysicalDefence = tempData._physicalDefence;
            ChiDefence = tempData._bendingDefence;
            Initiative = tempData._initiative;


            Strength = tempData.KuvvetBaseArtiZar;
            Dexterity = tempData.CevikeArtiZar;
            Constitution = tempData.DayaniklilikBaseArtiZar;
            Intelligence = tempData.ZekaBaseArtiZar;
            PhysicalPower = tempData.FizikselBaseArtiZar;
            ChiPower = tempData.CiBaseArtiZar;
            Charisma = tempData.KarizmaBaseArtiZar;

        }

        if (zarFireCode != null)
        {

            UnitName = tempData.Isim;
            Health = tempData._maxHealth;
            Stamina = tempData._physicalEnergy;
            Chi = tempData._chiEnergy;
            Speed = tempData._speed;
            PhysicalDefence = tempData._physicalDefence;
            ChiDefence = tempData._bendingDefence;
            Initiative = tempData._initiative;


            Strength = tempData.KuvvetBaseArtiZar;
            Dexterity = tempData.CevikeArtiZar;
            Constitution = tempData.DayaniklilikBaseArtiZar;
            Intelligence = tempData.ZekaBaseArtiZar;
            PhysicalPower = tempData.FizikselBaseArtiZar;
            ChiPower = tempData.CiBaseArtiZar;
            Charisma = tempData.KarizmaBaseArtiZar;

        }


        if (zarAirCode != null)
        {

            UnitName = tempData.Isim;
            Health = tempData._maxHealth;
            Stamina = tempData._physicalEnergy;
            Chi = tempData._chiEnergy;
            Speed = tempData._speed;
            PhysicalDefence = tempData._physicalDefence;
            ChiDefence = tempData._bendingDefence;
            Initiative = tempData._initiative;


            Strength = tempData.KuvvetBaseArtiZar;
            Dexterity = tempData.CevikeArtiZar;
            Constitution = tempData.DayaniklilikBaseArtiZar;
            Intelligence = tempData.ZekaBaseArtiZar;
            PhysicalPower = tempData.FizikselBaseArtiZar;
            ChiPower = tempData.CiBaseArtiZar;
            Charisma = tempData.KarizmaBaseArtiZar;

        }

        if (zarWaterCode != null)
        {

            UnitName = tempData.Isim;
            Health = tempData._maxHealth;
            Stamina = tempData._physicalEnergy;
            Chi = tempData._chiEnergy;
            Speed = tempData._speed;
            PhysicalDefence = tempData._physicalDefence;
            ChiDefence = tempData._bendingDefence;
            Initiative = tempData._initiative;


            Strength = tempData.KuvvetBaseArtiZar;
            Dexterity = tempData.CevikeArtiZar;
            Constitution = tempData.DayaniklilikBaseArtiZar;
            Intelligence = tempData.ZekaBaseArtiZar;
            PhysicalPower = tempData.FizikselBaseArtiZar;
            ChiPower = tempData.CiBaseArtiZar;
            Charisma = tempData.KarizmaBaseArtiZar;

        }


    }
    // Update is called once per frame
    void Update()
    {

    }
}
