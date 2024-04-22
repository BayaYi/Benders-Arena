using UnityEngine;
using UnityEngine.UI; // Image component'ine erişebilmek için gerekli

public class SaglikScript : MonoBehaviour
{
	// Sağlık barını tutan değişken
	public Image saglikBari;

	// Oyuncunun alabileceği maksimum sağlık değeri
	public int maksimumSaglik = 100;
	// Oyuncunun mevcut sağlığı
	private int saglik;
	// Mevcut sağlığın maksimum sağlık değerine oranı
	private float saglikOrani = 1.0f;

	// Sağlık full iken sağlık barının alacağı renk
	public Color doluSaglikRenk = Color.green;
	// Sağlık sıfır iken sağlık barının alacağı renk
	public Color bitmisSaglikRenk = Color.red;

	void Start()
	{
		// Oyuna full sağlık ile basla
		saglik = maksimumSaglik;
		
		// Sağlık barının rengini ayarla
		SaglikBariGuncelle();
	}

	public void SagligiDegistir( int miktar )
	{
		// Sağlığı artır/azalt
		saglik += miktar;
		
		// saglik'in 0 ile maksimumSaglik arasında olmasını garantile
		saglik = Mathf.Clamp( saglik, 0, maksimumSaglik );
		
		// Sağlık barını güncelle
		SaglikBariGuncelle();
	}

	void SaglikBariGuncelle()
	{
		// Mevcut sağlığın maksimum sağlığa oranını hesapla
		// Image'daki Radial 360'ın değeri 1 iken tüm daire çizilir, 0 iken hiçbir şey çizilmez
		// (yani değer 0 ile 1 arasında olmalı)
		saglikOrani = (float) saglik / maksimumSaglik;
		
		// Sağlık barının rengini ayarla
		saglikBari.color = Color.Lerp( bitmisSaglikRenk, doluSaglikRenk, saglikOrani );
	}

	void Update()
	{
		// Sağlık barının doluluk oranını (fillAmount) yumuşak bir şekilde (Lerp) değiştir
		// (buradaki 0.25 değeri, bu yumumşaklığın hızını belirler)
		saglikBari.fillAmount = Mathf.Lerp( saglikBari.fillAmount, saglikOrani, 0.25f );
	}
}