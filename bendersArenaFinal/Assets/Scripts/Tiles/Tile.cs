using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    GameObject bullet;
    public int G, H;
    public int F { get {  return G + H; } }

    public Tile _previous,_tile;
    private Pathfinder _pathFinder;
    private RangeFinder _rangeFinder;
    private PlayerBullet _bullet;
    private List<Tile> _path = new List<Tile>();
    private List<Tile> _inRangeTiles = new List<Tile>();
    [SerializeField] private Color _baseColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] public GameObject _highlight,_atkRange,_moveRange,_enemyHighlight;
    [SerializeField] public bool _isWalkable;
    public string TileName;

    public Vector3Int _tileLocation;


    public BaseUnit OccupiedUnit;
    public bool Walkable => _isWalkable && OccupiedUnit == null;

    private void Start()
    {
        _pathFinder = new Pathfinder();
        _rangeFinder = new RangeFinder();
        _bullet = new PlayerBullet();
    }

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
                GetInRangeTiles();
                AttackRange();

            }
            else
            {
                if (UnitManager.Instance.SelectedPlayer != null)
                {
                    
                    var enemy = (BaseEnemy)OccupiedUnit;
                    //Destroy(enemy.gameObject);  //Hasar mekaniði eklenecek...
                    Attack(UnitManager.Instance.SelectedPlayer, (BaseEnemy)OccupiedUnit);
                    UnitManager.Instance.SetSelectedPlayer(null);
                }
            }
        }
        else
        {
            if(UnitManager.Instance.SelectedPlayer!= null)
            {
                _tile = this;
                //SetUnit(UnitManager.Instance.SelectedPlayer);
                
                Move(UnitManager.Instance.SelectedPlayer, _tile);
                //UnitManager.Instance.SetSelectedPlayer(null);

            }
        }
        
    }

    public void LateUpdate()
    {
        if (_path.Count > 0)
        {
            var step = UnitManager.Instance.speed * Time.deltaTime;

            var yIndex = _path[0].transform.position.y;
            UnitManager.Instance.SelectedPlayer.transform.position = Vector3.MoveTowards(UnitManager.Instance.SelectedPlayer.transform.position, _path[0].transform.position, step);
            UnitManager.Instance.SelectedPlayer.transform.position = new Vector3(UnitManager.Instance.SelectedPlayer.transform.position.x, yIndex, UnitManager.Instance.SelectedPlayer.transform.position.z);

            if (Vector3.Distance(UnitManager.Instance.SelectedPlayer.transform.position, _path[0].transform.position) < 0.0001f)
            {
                PositionCharacterOnTile(UnitManager.Instance.SelectedPlayer, _path[0]);
                _path.RemoveAt(0);
            }
            


            if (_tile.transform.position.x == UnitManager.Instance.SelectedPlayer.transform.position.x && _tile.transform.position.z == UnitManager.Instance.SelectedPlayer.transform.position.z) {
                UnitManager.Instance.SelectedPlayer.OccupiedTile.OccupiedUnit = null;
                UnitManager.Instance.SelectedPlayer.OccupiedTile = _tile;
                _tile.OccupiedUnit = UnitManager.Instance.SelectedPlayer;
                
                UnitManager.Instance.SetSelectedPlayer(null); 

            }
        };

        if (_path.Count == 0)
        {
            GetInRangeTiles();
        }
    }

    private void GetInRangeTiles()
    {
        foreach (var item in _inRangeTiles)
        {
            _moveRange.SetActive(false);
        }

        if (UnitManager.Instance.SelectedPlayer != null)
        {
            if (UnitManager.Instance.SelectedPlayer.Faction == Faction.Player)
            {
                _inRangeTiles = _rangeFinder.GetTilesInRange(UnitManager.Instance.SelectedPlayer.OccupiedTile, UnitManager.Instance.moveRange);
            }

            foreach (var item in _inRangeTiles)
            {
                item._moveRange.SetActive(true);
            }
        }


    }

    private void AttackRange()
    {
        foreach (var item in _inRangeTiles)
        {
            _atkRange.SetActive(false);
        }

        if (UnitManager.Instance.SelectedPlayer != null)
        {
            if (UnitManager.Instance.SelectedPlayer.Faction == Faction.Player)
            {
                _inRangeTiles = _rangeFinder.GetTilesInRange(UnitManager.Instance.SelectedPlayer.OccupiedTile, UnitManager.Instance.atkRange);
            }

            foreach (var item in _inRangeTiles)
            {
                item._atkRange.SetActive(true);
            }
        }
    }

    public void Attack(BasePlayer player, BaseEnemy enemy)
    {
        if (_atkRange.activeSelf && _enemyHighlight.activeSelf)
        {
            Vector3 bulletLocation = _bullet.Konum(player, enemy);
            UnitManager.Instance.BulletCreate(bulletLocation);
            //Destroy(enemy.gameObject);
            //_bullet.Konum(player, enemy);
        }
    }


    public void Move(BasePlayer player, Tile endTile)
    {


        if (_moveRange.activeSelf)
        {
            _path = _pathFinder.FindPath(player.OccupiedTile, endTile, new List<Tile>());
        }
        

        
    
    }

    private void PositionCharacterOnTile(BasePlayer player,Tile tile)
    {
        player.transform.position = new Vector3(tile.transform.position.x, tile.transform.position.y + 0.0001f, tile.transform.position.z);
        
    }

    public void RangedAttack(BasePlayer player)
    {
        if (OccupiedUnit != null)
        {
            if (OccupiedUnit.Faction == Faction.Player)
            {
                

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
            if (UnitManager.Instance.SelectedPlayer != null)
            {
                SetUnit(UnitManager.Instance.SelectedPlayer);
                UnitManager.Instance.SetSelectedPlayer(null);

            }
        }




    }
}
