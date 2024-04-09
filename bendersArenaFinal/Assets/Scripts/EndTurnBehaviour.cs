using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurnBehaviour : MonoBehaviour
{
    public GameObject endTurn;
      

    public void OnButtonClick()
    {
        endTurn.SetActive(true);
    }
}
