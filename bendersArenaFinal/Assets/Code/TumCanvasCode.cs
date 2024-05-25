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
    }

     public void loadCanvas2()
    {

        Canvas.enabled = false;
        Canvas1.enabled = false;
        Canvas2.enabled = true;
        Canvas3.enabled = false;
    }

      public void loadCanvas3()
    {

        Canvas.enabled = false;
        Canvas1.enabled = false;
        Canvas2.enabled = false;
        Canvas3.enabled = true;
    }


    public void loadCanvasBack1()
    {
        Canvas.enabled = true;
        Canvas1.enabled = false;
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

