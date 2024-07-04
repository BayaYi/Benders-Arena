using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gerii : MonoBehaviour

{
    public Canvas Canvas4;
    public Canvas Canvas;
    public Canvas Canvas1;
    public Canvas Canvas2;
    public Canvas Canvas3;
    //public Canvas Canvas4;
    public Canvas Canvas5;
    public Canvas Canvas6;

    public Canvas Canvas8;
    public Canvas Canvas9;
    public Canvas Canvas10;
    public Canvas Canvas11;
    public Canvas Canvas12;
    public Canvas Canvas13;

    public Canvas Canvas01;

    public Canvas Canvas02;

    public Canvas Canvas03;

    public Canvas Canvas04;
    public Canvas Canvas05;
    public Canvas Canvas06;
    public Canvas Canvas07;
    public Canvas Canvas08;
    public Canvas Canvas09;
    public Canvas Canvas010;
    public Canvas Canvas011;
    public Canvas Canvas012;

    public void GoToScene16AndShowCanvas4()
    {
        SceneManager.LoadScene("TumCanvaslar");
        Canvas4.enabled =true;

        Canvas.enabled = false;
        Canvas1.enabled = true;
        Canvas2.enabled = false;
        Canvas3.enabled = false;
        //Canvas4.enabled = false;
        Canvas5.enabled = false;
        Canvas6.enabled = false;

        Canvas8.enabled = false;
        Canvas9.enabled = false;
        Canvas10.enabled = false;
        Canvas11.enabled = false;
        Canvas12.enabled = false;
        Canvas13.enabled = false;
        Canvas01.enabled = false;
        Canvas02.enabled = false;
        Canvas03.enabled = false;
        Canvas04.enabled = false;
        Canvas05.enabled = false;
        Canvas06.enabled = false;
        Canvas07.enabled = false;
        Canvas08.enabled = false;

        Canvas09.enabled = false;
        Canvas010.enabled = false;
        Canvas011.enabled = false;
        Canvas012.enabled = false;
    }
}




