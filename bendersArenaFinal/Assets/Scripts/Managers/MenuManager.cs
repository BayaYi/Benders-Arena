using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
// Tile.cs dosyasının namespace'i



public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;




    [SerializeField] private GameObject _selectedPlayerObject,_tileObject,_tileUnitObject;

    [SerializeField] private GameObject _attackButton, _moveButton, _endTurnButton;
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

        _selectedPlayerObject.GetComponentInChildren<Text>().text = "Tur S�ras� \n" + player.UnitName ;
        _selectedPlayerObject.SetActive(true);
    }


    public void MovePlayer(BasePlayer player)
{
    if (player == null)
    {
        _selectedPlayerObject.SetActive(false);
        return;
    }

    _selectedPlayerObject.GetComponentInChildren<Text>().text = "Tur Sirasi \n" + player.UnitName;
    _selectedPlayerObject.SetActive(true);

    // Burada UnitManager'dan seçili oyuncunun karo üzerine hareketini sağlayabiliriz
    if (UnitManager.Instance.SelectedPlayer != null)
    {

        UnitManager.Instance.SelectedPlayer.OccupiedTile.Move(UnitManager.Instance.SelectedPlayer, UnitManager.Instance.SelectedPlayer.OccupiedTile );
        // UnitManager.Instance.SetSelectedPlayer(null); // Bu satırı gerekiyorsa burada veya başka bir yerde kullanabilirsiniz
    }











}















}
