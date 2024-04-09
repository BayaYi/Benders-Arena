using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButtonBehavior : MonoBehaviour
{
    public Button attackButton;

    void Start()
    {
        attackButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        
        attackButton.gameObject.SetActive(false);
    }
    
}
