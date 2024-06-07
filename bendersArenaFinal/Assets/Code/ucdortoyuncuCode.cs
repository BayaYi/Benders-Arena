using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ucdortoyuncuCode : MonoBehaviour

{
    // Butona tıklanınca çalışacak fonksiyon
    public void ucOyuncuButton()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(18);
    }

    public void dortOyuncuButton()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(4);
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

    

     // Butona tıklanınca çalışacak fonksiyon

}



