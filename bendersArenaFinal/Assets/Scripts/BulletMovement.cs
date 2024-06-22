using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    BaseUnit _targetUnit;
    Tile _tile;
    
    public Rigidbody rb;
    // Start is called before the first frame update

    private void Awake()
    {
        _tile = new Tile();
    }
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.velocity = (_tile.OccupiedUnit.transform.position - transform.position) * 2f;
    } 
    private void OnCollisionEnter(Collision collision)
    {
        // Çarpýþmanýn gerçekleþtiði nesneyi kontrol et
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Eðer çarpýþan nesnenin tag'i "Enemy" ise, düþmana hasar ver
            //DealDamage(collision.gameObject);

            // Nesneyi yok et
            Destroy(gameObject);
        }
    }
}
