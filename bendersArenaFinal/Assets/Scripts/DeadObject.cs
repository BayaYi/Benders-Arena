using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public GameObject UIElementsAttack;
    public GameObject UIElementsEndTurn;
    public GameObject UIElementsDead;
    public void KillObject()
    {
        Destroy(gameObject);
        UIElementsAttack.SetActive(false);
        UIElementsEndTurn.SetActive(false);
        UIElementsDead.SetActive(true);

    }
}
