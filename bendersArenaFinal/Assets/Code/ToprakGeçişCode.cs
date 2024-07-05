using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToprakGeçişCode : MonoBehaviour
{
    [SerializeField] private InputField _name1Input;
    public TempData _tempData;
    public GameObject _gameObject,_playerControl;
    public PlayerControl _control;


    void Start()
    {
        _playerControl = GameObject.Find("PlayerControl");
        _control = _playerControl.GetComponent<PlayerControl>();
        _gameObject = GameObject.Find($"TempData{_control._playerNumber}");
        _tempData = _gameObject.GetComponent<TempData>();


    }
    // Start is called before the first frame update
    public void ToprakGeçişCodeButton()
    {
        _tempData.Isim = _name1Input.text;
        _tempData.Bukme = "Toprak";
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(17);
    }

      public void AteşGeçişCodeButton()
    {
        _tempData.Isim = _name1Input.text;
        _tempData.Bukme = "Ates";
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(13);
    }
       public void SuGeçişCodeButton()
    {
        _tempData.Isim = _name1Input.text;
        _tempData.Bukme = "Su";
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(14);
    }

        public void HavaGeçişCodeButton()
    {
        _tempData.Isim = _name1Input.text;
        _tempData.Bukme = "Hava";
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(15);
    }




}
