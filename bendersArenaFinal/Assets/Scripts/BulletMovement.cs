using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    GameObject _targetUnit;


    public Rigidbody rb;
    // Start is called before the first frame update

    void Start()
    {
        _targetUnit = GameObject.FindGameObjectWithTag("Target");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject _targetUnit = GameObject.FindGameObjectWithTag("Target");
        rb.velocity = (_targetUnit.transform.position - transform.position) * 2f;
    } 
    private void OnCollisionEnter(Collision collision)
    {
        // Çarpýþmanýn gerçekleþtiði nesneyi kontrol et
        if (collision.gameObject.CompareTag("Target"))
        {
            // Eðer çarpýþan nesnenin tag'i "Enemy" ise, düþmana hasar ver
            //DealDamage(collision.gameObject);
            _targetUnit.tag = "Enemy";
            // Nesneyi yok et
            Destroy(gameObject);
            
        }
    }
}
