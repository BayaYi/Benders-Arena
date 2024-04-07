using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButtonBehavior : MonoBehaviour
{
    public Button attackButton;
    //public Button endTurnButton;

    void Start()
    {
        attackButton.onClick.AddListener(OnButtonClick);
        //endTurnButton.onClick.AddListener(TurnEnding);
    }

    void OnButtonClick()
    {
        attackButton.onClick.RemoveListener(OnButtonClick);

        attackButton.gameObject.SetActive(false);
    }
    //void TurnEnding()
    //{
    //    // End turn butonunun týklama olayýný dinlemeyi býrakýn.
    //    endTurnButton.onClick.RemoveListener(TurnEnding);

    //    // End turn butonunu devre dýþý býrakýn.
    //    endTurnButton.gameObject.SetActive(false);

    //    // Attack butonunu tekrar aktif hale getirin.
    //    attackButton.gameObject.SetActive(true);

    //    // Attack butonunun týklama olayýný tekrar dinlemeye baþlayýn.
    //    attackButton.onClick.AddListener(OnButtonClick);
    //}
}
