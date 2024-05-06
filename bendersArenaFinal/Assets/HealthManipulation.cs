using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManipulation : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            HealthSystemForDummies healthSystem = collision.gameObject.GetComponent<HealthSystemForDummies>();
            healthSystem.AddToCurrentHealth(-10); // Can puanýndan 10 düþür
        }
        if (collision.transform.CompareTag("Player"))
        {
            HealthSystemForDummies healthSystem = collision.gameObject.GetComponent<HealthSystemForDummies>();
            healthSystem.AddToCurrentHealth(-10); // Can puanýndan 10 düþür
        }
    }
}
