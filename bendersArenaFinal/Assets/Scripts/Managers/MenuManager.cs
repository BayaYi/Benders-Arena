using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

   

    [SerializeField] private GameObject _selectedPlayerObject,_tileObject,_tileUnitObject;
    private void Awake()
    {
        Instance = this;
    }

   

    public void ShowTileInfo(Tile tile)
    {
       if (tile == null)
        {
            _tileObject.SetActive(false);
            _tileUnitObject.SetActive(false);
            return;
        }
        
        
        
        _tileObject.GetComponentInChildren<Text>().text = tile.TileName;
        //_tileObject.SetActive(true);
        
        if (tile.OccupiedUnit)
        {
            _tileUnitObject.GetComponentInChildren<Text>().text = tile.OccupiedUnit.UnitName;
            //_tileUnitObject.SetActive(true);
        }
       
    }

    public void ShowSelectedPlayer(BasePlayer player)
    {
       if (player == null)
        {
            _selectedPlayerObject.SetActive(false);
            return ;
        }

        _selectedPlayerObject.GetComponentInChildren<Text>().text = "Tur Sýrasý \n" + player.UnitName ;
        _selectedPlayerObject.SetActive(true);
    }


    

}
