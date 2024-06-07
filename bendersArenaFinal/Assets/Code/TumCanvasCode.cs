using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TumCanvasCode : MonoBehaviour

{
    //This was just used to load menu stuff properly and change scenes


    public Canvas Canvas;
    public Canvas Canvas1;
    public Canvas Canvas2;
    public Canvas Canvas3;
    public Canvas Canvas4;
    public Canvas Canvas5;
    public Canvas Canvas6;
    public Canvas Canvas7;
    public Canvas Canvas8;

    // Start is called before the first frame update
    public void loadMainMenu()
    {
        SceneManager.LoadScene(16);
    }


    public void loadCanvas1()
    {

        Canvas.enabled = false;
        Canvas1.enabled = true;
        Canvas2.enabled = false;
        Canvas3.enabled = false;
        Canvas4.enabled = false;
        Canvas5.enabled = false;
        Canvas6.enabled = false;
        Canvas7.enabled = false;
        Canvas8.enabled = false;
    }

     public void loadCanvas2()
    {

        Canvas.enabled = false;
        Canvas1.enabled = false;
        Canvas2.enabled = true;
        Canvas3.enabled = false;
        Canvas4.enabled = false;
        Canvas5.enabled = false;
        Canvas6.enabled = false;
        Canvas7.enabled = false;
        Canvas8.enabled = false;
    }

      public void loadCanvas3()
    {

        Canvas.enabled = false;
        Canvas1.enabled = false;
        Canvas2.enabled = false;
        Canvas3.enabled = true;
        Canvas4.enabled = false;
        Canvas5.enabled = false;
        Canvas6.enabled = false;
        Canvas7.enabled = false;
        Canvas8.enabled = false;
    }

      public void loadCanvas4()
    {

        Canvas.enabled = false;
        Canvas1.enabled = false;
        Canvas2.enabled = false;
        Canvas3.enabled = false;
        Canvas4.enabled = true;
        Canvas5.enabled = false;
        Canvas6.enabled = false;
        Canvas7.enabled = false;
        Canvas8.enabled = false;
    }

      public void loadCanvas5()
    {

        Canvas.enabled = false;
        Canvas1.enabled = false;
        Canvas2.enabled = false;
        Canvas3.enabled = false;
        Canvas4.enabled = false;
        Canvas5.enabled = true;
        Canvas6.enabled = false;
        Canvas7.enabled = false;
        Canvas8.enabled = false;
    }

    public void loadCanvas6()
    {

        Canvas.enabled = false;
        Canvas1.enabled = false;
        Canvas2.enabled = false;
        Canvas3.enabled = false;
        Canvas4.enabled = false;
        Canvas5.enabled = false;
        Canvas6.enabled = true;
        Canvas7.enabled = false;
        Canvas8.enabled = false;

    }

     public void loadCanvas7()
    {

        Canvas.enabled = false;
        Canvas1.enabled = false;
        Canvas2.enabled = false;
        Canvas3.enabled = false;
        Canvas4.enabled = false;
        Canvas5.enabled = false;
        Canvas6.enabled = false;
        Canvas7.enabled = true;
        Canvas8.enabled = false;

    }

    public void loadCanvas8()
    {

        Canvas.enabled = false;
        Canvas1.enabled = false;
        Canvas2.enabled = false;
        Canvas3.enabled = false;
        Canvas4.enabled = false;
        Canvas5.enabled = false;
        Canvas6.enabled = false;
        Canvas7.enabled = false;
        Canvas8.enabled = true;

    }


    public void loadCanvasBack1()
    {
        Canvas.enabled = true;
        Canvas1.enabled = false;
        Canvas2.enabled = false;
        Canvas3.enabled = false;
        Canvas4.enabled = false;
        Canvas5.enabled = false;

    }

     public void loadCanvasBack2()
    {
        Canvas.enabled = false;
        Canvas1.enabled = true;
        Canvas2.enabled = false;
        Canvas3.enabled = false;
        Canvas4.enabled = false;
        Canvas5.enabled = false;
    }

    public void loadCanvasBack3()
    {
        Canvas.enabled = false;
        Canvas1.enabled = false;
        Canvas2.enabled = true;
        Canvas3.enabled = false;
        Canvas4.enabled = false;
        Canvas5.enabled = false;
    }
     public void loadCanvasBack4()
    {
        Canvas.enabled = false;
        Canvas1.enabled = true;
        Canvas2.enabled = false;
        Canvas3.enabled = false;
        Canvas4.enabled = false;
        Canvas5.enabled = false;
    }

  public void player1Button3()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }

    public void player2Button3()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }

    public void player3Button3()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }

    public void player1Button4()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }

    public void player2Button4()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }

    public void player3Button4()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }

    public void player4Button4()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene(12);
    }




/*
    public void loadHelpCanvas2()
    {
        helpCanvas.enabled = false;
        helpCanvas2.enabled = true;
    }

    public void loadMainCanvas()
    {
        mainCanvas.enabled = true;
        helpCanvas.enabled = false;
        helpCanvas2.enabled = false;
    }*/
}

