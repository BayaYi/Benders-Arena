using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempDataOnLoad : MonoBehaviour
{
    public GameObject GameObject1;
    public GameObject GameObject2;
    public GameObject GameObject3;
    public GameObject GameObject4;
    public GameObject GameObject5;
    public GameObject GameObject6;
    public GameObject GameObject7;
    public GameObject GameObject8;
    public GameObject GameObject9;

    public void Awake()
    {
        GameObject1 = GameObject.Find("TempData0");
        GameObject2 = GameObject.Find("TempData1");
        GameObject3 = GameObject.Find("TempData2");
        GameObject4 = GameObject.Find("TempData3");
        GameObject5 = GameObject.Find("PlayerControl");
        GameObject6 = GameObject.Find("PlayerData0");
        GameObject7 = GameObject.Find("PlayerData1");
        GameObject8 = GameObject.Find("PlayerData2");
        GameObject9 = GameObject.Find("PlayerData3");

        DontDestroyOnLoad(GameObject1);
        DontDestroyOnLoad(GameObject2);
        DontDestroyOnLoad(GameObject3);
        DontDestroyOnLoad(GameObject4);
        DontDestroyOnLoad(GameObject5);
        DontDestroyOnLoad(GameObject6);
        DontDestroyOnLoad(GameObject7);
        DontDestroyOnLoad(GameObject8);
        DontDestroyOnLoad(GameObject9);
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
