using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1Code : MonoBehaviour
{
    // Butona tıklanınca çalışacak fonksiyon
    public void CampaignButton()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(1);
    }

     // Butona tıklanınca çalışacak fonksiyon
    public void SettingsButton()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(2);
    }

    // Geri dönüş yapılacak sahnenin index değeri
    public int geriDönüşSahneIndex = 0; // Varsayılan olarak ilk sahne index'i (0) kullanılır.

    void Start()
    {
        // Eğer geri dönüş yapılacak sahnenin index'i belirtilmemişse, ilk sahne index'ini al
        if (geriDönüşSahneIndex == -1)
        {
            geriDönüşSahneIndex = 0;
        }
    }

    // Geri gitme işlevini sağlayan metod
    public void GeriGit()
    {
        // Belirtilen sahneye geri dön
        SceneManager.LoadScene(geriDönüşSahneIndex);
    }

    public void CreativeButton()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(3);
    }

     // Butona tıklanınca çalışacak fonksiyon

}




