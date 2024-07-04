using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : BasePlayer
{
    public static Player1 instance;

    public void Awake()
    {
        // Eğer başka bir instance varsa bu instance'ı yok et
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Referans için ZarToprakCode nesnesi
    public ZarToprakCode zarToprakCode;

    // Start is called before the first frame update
    public void Start()
    {
        if (zarToprakCode != null)
        {


            Health = int.Parse(zarToprakCode.totalHealthText.text);
            Stamina = int.Parse(zarToprakCode.totalPhysicalEnergyText.text);
            Chi = int.Parse(zarToprakCode.totalChiEnergyText.text);
            Speed = int.Parse(zarToprakCode.totalSpeedText.text);
            PhysicalDefence = int.Parse(zarToprakCode.totalPhysicalDefenceText.text);
            ChiDefence = int.Parse(zarToprakCode.totalBendingDefenceText.text);
            Initiative = int.Parse(zarToprakCode.totalInitiativeText.text);


            Strength = int.Parse(zarToprakCode.totalScoreText.text);
            Dexterity = int.Parse(zarToprakCode.totalScoreText1.text);
            Constitution = int.Parse(zarToprakCode.totalScoreText2.text);
            Intelligence = int.Parse(zarToprakCode.totalScoreText3.text);
            PhysicalPower = int.Parse(zarToprakCode.totalScoreText4.text);
            ChiPower = int.Parse(zarToprakCode.totalScoreText5.text);
            Charisma = int.Parse(zarToprakCode.totalScoreText6.text);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
