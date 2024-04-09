using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisable : MonoBehaviour
{
    public GameObject targetObject;
    // Start is called before the first frame update
    public void OnButtonClick()
    {

        targetObject.SetActive(false);
    }
}
