using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OyuncuCode : MonoBehaviour
{
    GameObject _playerControl;
    PlayerControl _control;

    public void Awake()
    {
        _playerControl = GameObject.Find("PlayerControl");
        _control = _playerControl.GetComponent<PlayerControl>();
    }

    public void KarakterKağidi()
    {
        _control._playerNumber = 0;
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }

    public void KarakterKağidi2()
    {
        _control._playerNumber = 1;
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }
    public void KarakterKağidi3()
    {
        _control._playerNumber = 2; 
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }
    public void KarakterKağidi4()
    {
        _control._playerNumber = 3;
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
