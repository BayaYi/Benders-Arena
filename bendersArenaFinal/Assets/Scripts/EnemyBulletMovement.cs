using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject enemyNesnesi = GameObject.FindGameObjectWithTag("Player");
        rb.velocity = (enemyNesnesi.transform.position - transform.position) * 2f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Çarpýþmanýn gerçekleþtiði nesneyi kontrol et
        if (collision.gameObject.CompareTag("Player"))
        {
            // Eðer çarpýþan nesnenin tag'i "Enemy" ise, düþmana hasar ver
            //DealDamage(collision.gameObject);

            // Nesneyi yok et
            Destroy(gameObject);
        }
    }
}
