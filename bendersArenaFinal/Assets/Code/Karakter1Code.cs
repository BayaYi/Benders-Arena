using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Karakter1Code : MonoBehaviour
{
    // Butona tıklanınca çalışacak fonksiyon
    public void NewPageButton()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(11);
    }
}
