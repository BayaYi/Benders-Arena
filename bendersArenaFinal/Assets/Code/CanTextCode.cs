using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanTextCode : MonoBehaviour

{
    public Text IkinciCanBariYazisi; // Sadece can miktarını göstermek için Text nesnesi

    public string Canimiz { get; private set; }

    // Diğer değişkenler ve fonksiyonlar burada...

    void CanBarlariniKontrolEt()
    {
        // Diğer işlemler...

        // Sadece can miktarını yazdıran kısım:
        IkinciCanBariYazisi.text = Canimiz + "/100";
    }

    // Diğer fonksiyonlar burada...
}


