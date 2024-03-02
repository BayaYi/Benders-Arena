using UnityEngine;
using UnityEngine.SceneManagement;

public class CampaignScript : MonoBehaviour
{
    // Butona tıklanınca çalışacak fonksiyon
    public void ButonaTiklandi()
    {
        // İkinci sahneyi yükleyin (sahne adını doğru şekilde değiştirin)
        SceneManager.LoadScene("scene2");
    }
}
