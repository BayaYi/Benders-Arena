using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnable : MonoBehaviour
{
    public GameObject targetObject;
    public void OnButtonClick()
    {
        targetObject.SetActive(true);
    }
}
