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
    public int alinanStrength;
    public int alinanDexterity;
    public int alinanConstitution;
    public int alinanIntelligence;
    public int alinanChiPower;
    public int alinanPhysicalPower;
    public int alinanCharisma;
}
