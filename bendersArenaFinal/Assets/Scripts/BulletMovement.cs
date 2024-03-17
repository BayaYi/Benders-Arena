using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.right * 2f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        // �arp��man�n ger�ekle�ti�i nesneyi kontrol et
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // E�er �arp��an nesnenin tag'i "Enemy" ise, d��mana hasar ver
            //DealDamage(collision.gameObject);

            // Nesneyi yok et
            Destroy(gameObject);
        }
    }
}
