using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YonCode : MonoBehaviour
{
    GameObject GameObject0;
    GameObject GameObject1;
    GameObject GameObject2;
    GameObject GameObject3;
    TempData tempData0;
    TempData tempData1;
    TempData tempData2;
    TempData tempData3;
    PlayerControl playerControl;

     public void ileri1()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(20);
    }
     public void ileri2()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(21);
    }

    public void geri2()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(23);
    }
     public void ileri3()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(22);
    }

    public void geri3()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(20);
    }
     public void ileri4()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }

    public void geri4()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(22);
    }
     public void ileri5()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }
     public void ileri6()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }
     public void ileri7()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }

    public void ileri8()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(24);
    }

     public void ileriNasil1()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(25);
    }

    public void ileriNasil2()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(26);
    }

    public void ileriNasil3()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(27);
    }

    public void ileriNasil4()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(28);
    }

    public void ileriNasil5()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(29);
    }

    public void ileriNasil6()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(30);
    }

     public void ileriNasil7()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(31);
    }

     public void ileriNasil8()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(32);
    }

    public void ileriNasil9()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(33);
    }

    public void ileriNasi20()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(35);
    }
    public void ileriNasil10()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(34);
    }

    public void ileriNasil11()
    {
        GameObject0 = GameObject.Find("TempData0");
        tempData0 = GameObject0.GetComponent<TempData>();
        GameObject1 = GameObject.Find("TempData1");
        tempData1 = GameObject1.GetComponent<TempData>();
        GameObject2 = GameObject.Find("TempData2");
        tempData2 = GameObject0.GetComponent<TempData>();
        GameObject3 = GameObject.Find("TempData3");
        tempData3 = GameObject1.GetComponent<TempData>();

        if (tempData0._isCreated && tempData1._isCreated && tempData2._isCreated && tempData3._isCreated)
        {
            // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
            SceneManager.LoadScene(19);
        }
    }

    public void ileriNasil12()
    {
        GameObject0 = GameObject.Find("PlayerControl");
        playerControl = GameObject0.GetComponent<PlayerControl>();
        GameObject1 = GameObject.Find($"TempData{playerControl._playerNumber}");
        tempData0 = GameObject1.GetComponent <TempData>();
        tempData0._isCreated = true;

        SceneManager.LoadScene(22);
    }






}
