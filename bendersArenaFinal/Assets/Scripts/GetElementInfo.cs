using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetElementInfo : MonoBehaviour
{
    public GameObject GameObject1;
    public GameObject GameObject2;
    public PlayerControl playerControl;
    public TempUnit tempUnit;
    // Start is called before the first frame update
    void Start()
    {
        GameObject1 = GameObject.Find("PlayerControl");
        playerControl = GameObject1.GetComponent<PlayerControl>();
        GameObject2 = GameObject.Find($"PlayerData{playerControl._playerNumber}");
        tempUnit = GameObject2.GetComponent<TempUnit>();

        tempUnit.GetElementData();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
