using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatCekme : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Strength" + alinanStrength);
    }
    public BendingAbility alinanBending = BendingAbility.fire;
    public int alinanStrength=3;
    public int alinanDexterity=3;
    public int alinanConstitution = 3;
    public int alinanIntelligence = 3;
    public int alinanChiPower = 3;
    public int alinanPhysicalPower = 3;
    public int alinanCharisma = 3;
}
