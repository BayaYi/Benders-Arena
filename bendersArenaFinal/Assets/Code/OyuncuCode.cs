using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OyuncuCode : MonoBehaviour
{
    public GameObject Oyuncu;

    public void KarakterKağidi()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }
    public void KarakterKağidigeri()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(16);

    }

    public void AnaSahne()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        //SceneManager.LoadScene(19, LoadSceneMode.Additive);

        //SceneManager.MoveGameObjectToScene(Oyuncu, SceneManager.GetSceneByBuildIndex(19));

         SceneManager.LoadScene(19);



    }
}
