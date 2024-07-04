using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
// Tile.cs dosyasının namespace'i



public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;




    [SerializeField] private GameObject _selectedPlayerObject,_tileObject,_tileUnitObject;

    [SerializeField] private GameObject _attackButton, _moveButton, _endTurnButton, _backButton;
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

    public void TurnStart(BaseUnit unit)
    {
        if (unit == null)
        {
            _attackButton.SetActive(false);
            _moveButton.SetActive(false);
            _endTurnButton.SetActive(false);
            _backButton.SetActive(false);
        }

        else
        {
            _attackButton.SetActive(true);
            _moveButton.SetActive(true);
            _endTurnButton.SetActive(true);
            _backButton.SetActive(false);
        }
    }
    
    
    
    public void AttackButton()
    {
        GameManager.Instance.ChangeState(GameState.AttackState);
        Tile.Instance.AttackRange();
        _attackButton.SetActive(false);
        _moveButton.SetActive(false);
        _endTurnButton.SetActive(false);
        _backButton.SetActive(true);
    }

    public void MoveButton()
    {
        GameManager.Instance.ChangeState(GameState.MoveState);
        Tile.Instance.GetInRangeTiles();
        _attackButton.SetActive(false);
        _moveButton.SetActive(false);
        _endTurnButton.SetActive(false);
        _backButton.SetActive(true);
    }
    public void BackButton()
    {
        GameManager.Instance.ChangeState(GameState.WaitState);
        _backButton.SetActive(false);
        _attackButton.SetActive(true);
        _moveButton.SetActive(true);
        _endTurnButton.SetActive(true);
    }

    public void EndTurnButton()
    {
        _attackButton.SetActive(false);
        _moveButton.SetActive(false);
        _endTurnButton.SetActive(false);
        _backButton.SetActive(false);
        UnitManager.Instance.SelectedUnit.OccupiedTile._turnHighlight.SetActive(false);
        GameManager.Instance.ChangeState(GameState.ChangeTurnOrder);
    }
    
    
    
    
    
    
    
    
    /*public void MovePlayer(BasePlayer player)
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
    }*/










}
















