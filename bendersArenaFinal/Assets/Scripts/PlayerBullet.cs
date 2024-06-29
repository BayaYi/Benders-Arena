using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet 
{
    public GameObject bullet;
    public Vector3 bulletLocation = Vector3.zero;

    public Vector3 Konum(BasePlayer player, BaseEnemy enemy)
    {
        //Belirtilen etikete sahip nesneyi bulan ve yeni bir obje olarak atand�
        BaseUnit playerNesnesi = player;
        BaseUnit enemyNesnesi = enemy;

        //Objelerin Konumlar� bulundu.
        Vector3 playerKonumu = playerNesnesi.transform.position;
        Vector3 enemyKonumu = enemyNesnesi.transform.position;

        //Konum farklar� mutlak de�er cinsinden belirlendi ve en y�ksek farka g�re merminin konumlanaca�� yer hesapland�.
        float xfark = Mathf.Abs(playerKonumu.x - enemyKonumu.x);
        float yfark = Mathf.Abs(playerKonumu.y - enemyKonumu.y);
        float zfark = Mathf.Abs(playerKonumu.z - enemyKonumu.z);

        if (xfark > yfark && xfark > zfark)
        {
            if (playerKonumu.x > enemyKonumu.x)
            {
                bulletLocation = (Vector3.up * 5) + (Vector3.left * 5) + playerKonumu;
            }
            else
            {
                bulletLocation = (Vector3.up * 5) + (Vector3.right * 5) + playerKonumu;
            }
        }
        else if (yfark > xfark && yfark > zfark)
        {
            if (playerKonumu.y > enemyKonumu.y)
            {
                //bulletLocation = (Vector3.down * 5) + playerKonumu;
            }
            else
            {
                bulletLocation = (Vector3.up * 5) + playerKonumu;
            }
        }
        else
        {
            if (playerKonumu.z > enemyKonumu.z)
            {
                bulletLocation = (Vector3.up * 5) + (Vector3.back * 5) + playerKonumu;
            }
            else
            {
                bulletLocation = (Vector3.up * 5) + (Vector3.forward * 5) + playerKonumu;
            }
        }
        //Mermi olu�turuldu.
        //Instantiate(bullet, bulletLocation, Quaternion.identity);
        return bulletLocation;

    }
}
