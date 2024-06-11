using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
    [SerializeField] private bool _isWalkable;
    public string TileName;


    public BaseUnit OccupiedUnit;
    public bool Walkable => _isWalkable && OccupiedUnit == null;

    private void OnMouseEnter()
    {
        _highlight.SetActive(true);
        MenuManager.Instance.ShowTileInfo(this);

    }

    private void OnMouseExit()
    {
        _highlight.SetActive(false);
        MenuManager.Instance.ShowTileInfo(null);
    }

    public void SetUnit(BaseUnit unit)
    {
        if (unit.OccupiedTile != null) unit.OccupiedTile.OccupiedUnit = null;
        unit.transform.position = transform.position;
        OccupiedUnit = unit;
        unit.OccupiedTile = this;
    }

    public void OnMouseDown()
    {
        //if (GameManager.Instance.GameState != GameState.PlayerTurn) return;

        if (OccupiedUnit != null)
        {
            if (OccupiedUnit.Faction == Faction.Player)
            {
                UnitManager.Instance.SetSelectedPlayer((BasePlayer)OccupiedUnit);
                
            }
            else
            {
                if (UnitManager.Instance.SelectedPlayer != null)
                {
                    
                    var enemy = (BaseEnemy)OccupiedUnit;
                    Destroy(enemy.gameObject);//Hasar mekaniði eklenecek...
                    UnitManager.Instance.SetSelectedPlayer(null);
                }
            }
        }
        else
        {
            if(UnitManager.Instance.SelectedPlayer!= null)
            {
                SetUnit(UnitManager.Instance.SelectedPlayer);
                UnitManager.Instance.SetSelectedPlayer(null);

            }
        }
        
    }
}
