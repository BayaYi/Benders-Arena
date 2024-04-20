using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanBarCode : MonoBehaviour
{
    public Image BirinciCanBari; // Değişiklik burada: Slider yerine Image kullanıldı
    public Image IkinciCanBari;
    public Text IkinciCanBariYazisi;
    public float DoluCanimiz = 100f;
    public float Canimiz;

    void Start()
    {
        BirinciCanBari = GameObject.FindWithTag("canbari1").GetComponent<Image>();
        IkinciCanBari = GameObject.FindWithTag("canbari2").GetComponent<Image>();
        Canimiz = DoluCanimiz;
    }

    void Update()
    {
        CanBarlariniKontrolEt();
    }

    void CanBarlariniKontrolEt()
    {
        BirinciCanBari.fillAmount = Canimiz / DoluCanimiz; // Slider yerine Image kullanıldığı için fillAmount kullanıldı
        IkinciCanBari.fillAmount = Canimiz / DoluCanimiz;
        IkinciCanBariYazisi.text = Canimiz + "/100";
    }

    public void CanDoldur(int Can)
    {
        Canimiz += Can;
        if (Canimiz >= DoluCanimiz)
            Canimiz = DoluCanimiz;
    }

    public void HasarVer(int Hasar)
    {
        Canimiz -= Hasar;
        if (Canimiz <= 0)
            Canimiz = 0;
    }
}
