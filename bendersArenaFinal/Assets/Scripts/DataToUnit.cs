using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataToUnit : MonoBehaviour
{

    public GameObject GameObject1;
    public GameObject GameObject2;
    public GameObject GameObject3;
    public PlayerControl playerControl;
    public TempUnit tempUnit;
    public TempData tempData;
    // Start is called before the first frame update
    void Start()
    {
        GameObject3 = GameObject.Find("PlayerControl");
        playerControl = GameObject3.GetComponent<PlayerControl>();
        GameObject1 = GameObject.Find($"TempData{playerControl._playerNumber}");
        GameObject2 = GameObject.Find($"PlayerData{playerControl._playerNumber}");
        tempUnit = GameObject2.GetComponent<TempUnit>();
        tempData = GameObject1.GetComponent<TempData>();

        tempUnit.GetTempData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
