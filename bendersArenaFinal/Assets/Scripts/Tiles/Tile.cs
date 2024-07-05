using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{

    GameObject bullet;
    public int G, H;
    public int F { get {  return G + H; } }

    public static Tile Instance;
    public Tile _previous,_tile;
    private Pathfinder _pathFinder;
    private RangeFinder _rangeFinder;
    private PlayerBullet _bullet;
    private List<Tile> _path = new List<Tile>();
    private List<Tile> _inRangeTiles = new List<Tile>();
    [SerializeField] private Color _baseColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] public GameObject _highlight,_atkRange,_moveRange,_enemyHighlight,_turnHighlight;
    [SerializeField] public bool _isWalkable;
    public string TileName;
    
    public Vector3Int _tileLocation;


    public BaseUnit OccupiedUnit;
    public bool Walkable => _isWalkable && OccupiedUnit == null;

    private void Start()
    {
        Instance = this;
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
            /*if (OccupiedUnit.Faction == Faction.Player && UnitManager.Instance.SelectedUnit == null)
            {
                UnitManager.Instance.SetSelectedPlayer((BasePlayer)OccupiedUnit);
                UnitManager.Instance.SetSelectedUnit((BaseUnit)OccupiedUnit);
                //GetInRangeTiles();
                //AttackRange();

            }
            else if(OccupiedUnit.Faction == Faction.Enemy && UnitManager.Instance.SelectedUnit == null)
            {
                UnitManager.Instance.SetSelectedEnemy((BaseEnemy)OccupiedUnit);
                UnitManager.Instance.SetSelectedUnit((BaseUnit)OccupiedUnit);
                //GetInRangeTiles();
                //AttackRange();

            }
            else {*/
                if (UnitManager.Instance.SelectedUnit.Faction == Faction.Player && OccupiedUnit.Faction == Faction.Enemy && GameManager.Instance.GameState == GameState.AttackState)
                {
                    
                    var enemy = (BaseEnemy)OccupiedUnit;
                    //Destroy(enemy.gameObject);  //Hasar mekaniði eklenecek...
                    Attack(UnitManager.Instance.SelectedPlayer, (BaseEnemy)OccupiedUnit);
                UnitManager.Instance.SelectedUnit.OccupiedTile._turnHighlight.SetActive(false);
                UnitManager.Instance.SetSelectedPlayer(null);
                    UnitManager.Instance.SetSelectedUnit(null);
                    GameManager.Instance.ChangeState(GameState.ChangeTurnOrder);
                }
                
                else if(UnitManager.Instance.SelectedUnit.Faction == Faction.Enemy && OccupiedUnit.Faction == Faction.Player && GameManager.Instance.GameState == GameState.AttackState)
                {
                    
                        var player = (BasePlayer)OccupiedUnit;
                        MonsterAttack(UnitManager.Instance.SelectedEnemy, (BasePlayer)OccupiedUnit);
                    UnitManager.Instance.SelectedUnit.OccupiedTile._turnHighlight.SetActive(false);
                    UnitManager.Instance.SetSelectedEnemy(null);
                        UnitManager.Instance.SetSelectedUnit(null);
                        GameManager.Instance.ChangeState(GameState.ChangeTurnOrder);
                    
                }
               
            //}
            /*if (OccupiedUnit.Faction == Faction.Enemy)
            {
                UnitManager.Instance.SetSelectedEnemy((BaseEnemy)OccupiedUnit);
                UnitManager.Instance.SetSelectedUnit((BaseUnit)OccupiedUnit);
                GetInRangeTiles();
                AttackRange();

            }
            else
            {
                if (UnitManager.Instance.SelectedUnit.Faction == Faction.Enemy)
                {
                    var player = (BaseEnemy)OccupiedUnit;
                    //Destroy(enemy.gameObject);  //Hasar mekaniði eklenecek...
                    Attack(UnitManager.Instance.SelectedPlayer, (BaseEnemy)OccupiedUnit);
                    UnitManager.Instance.SetSelectedPlayer(null);
                }
            }*/
        }
        else
        {
            if(UnitManager.Instance.SelectedUnit!= null)
            {
                _tile = this;
                //SetUnit(UnitManager.Instance.SelectedPlayer);
                if (UnitManager.Instance.SelectedUnit.Faction == Faction.Enemy)
                {
                    UnitManager.Instance.SelectedUnit.OccupiedTile._enemyHighlight.SetActive(false);
                }

                if (UnitManager.Instance.SelectedUnit.OccupiedTile._turnHighlight)
                {
                    Move(UnitManager.Instance.SelectedUnit, _tile);
                }
                //UnitManager.Instance.SetSelectedPlayer(null);
                
                    UnitManager.Instance.SelectedUnit.OccupiedTile._turnHighlight.SetActive(false);
                

            }
            /*if (UnitManager.Instance.SelectedEnemy != null)
            {
                _tile = this;
                //SetUnit(UnitManager.Instance.SelectedPlayer);
                EnemyMove(UnitManager.Instance.SelectedEnemy, _tile);
                //UnitManager.Instance.SetSelectedPlayer(null);

            }*/
        }
        
    }

    public void LateUpdate()
    {
        if (_path.Count > 0)
        {
            var step = UnitManager.Instance.speed * Time.deltaTime;
            
            var yIndex = _path[0].transform.position.y;
            UnitManager.Instance.SelectedUnit.transform.position = Vector3.MoveTowards(UnitManager.Instance.SelectedUnit.transform.position, _path[0].transform.position, step);
            UnitManager.Instance.SelectedUnit.transform.position = new Vector3(UnitManager.Instance.SelectedUnit.transform.position.x, yIndex, UnitManager.Instance.SelectedUnit.transform.position.z);

            if (Vector3.Distance(UnitManager.Instance.SelectedUnit.transform.position, _path[0].transform.position) < 0.0001f)
            {
                PositionCharacterOnTile(UnitManager.Instance.SelectedUnit, _path[0]);
                _path.RemoveAt(0);
            }
            


            if (_tile.transform.position.x == UnitManager.Instance.SelectedUnit.transform.position.x && _tile.transform.position.z == UnitManager.Instance.SelectedUnit.transform.position.z) {
                UnitManager.Instance.SelectedUnit.OccupiedTile.OccupiedUnit = null;
                UnitManager.Instance.SelectedUnit.OccupiedTile = _tile;
                _tile.OccupiedUnit = UnitManager.Instance.SelectedUnit;
                if (UnitManager.Instance.SelectedUnit.Faction == Faction.Enemy)
                {
                    _tile._enemyHighlight.SetActive(true);
                }
                
                UnitManager.Instance.SetSelectedPlayer(null); 
                UnitManager.Instance.SetSelectedEnemy(null);
                UnitManager.Instance.SetSelectedUnit(null);
                
                GameManager.Instance.ChangeState(GameState.ChangeTurnOrder);
                

            }
        }

        if (UnitManager.Instance.SelectedUnit == null)
        {
            GetInRangeTiles();
        }

        if (UnitManager.Instance.SelectedUnit == null)
        {
            AttackRange();
        }
    }

    public void GetInRangeTiles()
    {
        foreach (var item in _inRangeTiles)
        {
            item._moveRange.SetActive(false);
        }

        if (UnitManager.Instance.SelectedUnit != null)
        {
            if (UnitManager.Instance.SelectedUnit.Faction == Faction.Player || UnitManager.Instance.SelectedUnit.Faction == Faction.Enemy)
            {
                _inRangeTiles = _rangeFinder.GetTilesInRange(UnitManager.Instance.SelectedUnit.OccupiedTile, UnitManager.Instance.moveRange);
            }



            foreach (var item in _inRangeTiles)
            {
                item._moveRange.SetActive(true);
            }
        }
       


    }

    public void AttackRange()
    {
        foreach (var item in _inRangeTiles)
        {
            item._atkRange.SetActive(false);
        }

        if (UnitManager.Instance.SelectedUnit != null)
        {
            if (UnitManager.Instance.SelectedUnit.Faction == Faction.Player || UnitManager.Instance.SelectedUnit.Faction == Faction.Enemy)
            {
                _inRangeTiles = _rangeFinder.GetTilesInRange(UnitManager.Instance.SelectedUnit.OccupiedTile, UnitManager.Instance.atkRange);
            }

            foreach (var item in _inRangeTiles)
            {
                item._atkRange.SetActive(true);
            }
        }
    }

    public void Attack(BaseUnit unit1, BaseUnit unit2)
    {
        if (_atkRange.activeSelf && _enemyHighlight.activeSelf)
        {
            Vector3 bulletLocation = _bullet.Konum(unit1, unit2);
            
            unit2.tag = "Target";
            UnitManager.Instance.BulletCreate(bulletLocation);
            //Destroy(enemy.gameObject);
            //_bullet.Konum(player, enemy);
        }
    }


    public void Move(BaseUnit unit, Tile endTile)
    {


        if (_moveRange.activeSelf)
        {
            _path = _pathFinder.FindPath(unit.OccupiedTile, endTile, new List<Tile>());
        }
        

        
    
    }

    public void EnemyMove(BaseEnemy enemy, Tile endTile)
    {


        if (_moveRange.activeSelf)
        {
            _path = _pathFinder.FindPath(enemy.OccupiedTile, endTile, new List<Tile>());
        }




    }

    private void PositionCharacterOnTile(BaseUnit unit,Tile tile)
    {
        unit.transform.position = new Vector3(tile.transform.position.x, tile.transform.position.y + 0.0001f, tile.transform.position.z);
        
    }

    public void MonsterAttack(BaseUnit unit1, BaseUnit unit2)
    {
        Vector3 bulletLocation = _bullet.Konum(unit1, unit2);

        unit2.tag = "Target";
        UnitManager.Instance.EnemyBulletCreate(bulletLocation);




    }
}
