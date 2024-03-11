using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KarakterKa2Code : MonoBehaviour


    {
// Geri dönüş yapılacak sahnenin index değeri
    public int geriDönüşSahneIndex = 10; // Varsayılan olarak ilk sahne index'i (0) kullanılır.


    // Geri gitme işlevini sağlayan metod
    public void GeriGit()
    {
        // Belirtilen sahneye geri dön
        SceneManager.LoadScene(geriDönüşSahneIndex);
    }

}
