using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

static class Constants
{
    public const int HEROES = 4;
    public const int ENEMY = 2;
}
public class UnitManager : MonoBehaviour
{
    public BaseUnit tempUnit;
    public GameObject tempData;

    HealthSystemForDummies healthSystem;

    public int spawnCounter;
    public float speed;
    public int atkRange;
    public int moveRange;

    public int enemyAtkRange;
    public int enemyMoveRange;
    public int TurnNumber = 0;

    public GameObject Bullet;
    public GameObject EnemyBullet;

    public static UnitManager Instance;

    private List<ScriptableUnit> _units;

    public BaseUnit SelectedUnit;
    public BasePlayer SelectedPlayer;
    public BaseEnemy SelectedEnemy;

    public List<BaseUnit> _unitList;
    private void Awake()
    {
        Instance = this;

        _units = Resources.LoadAll<ScriptableUnit>("Units").ToList();
    }

    public void SpawnPlayers()
    {
        var heroCount = Constants.HEROES;

        for (int i = 0; i < heroCount; i++)
        {
           tempData = GameObject.Find($"PlayerData{i}");
            tempUnit = tempData.GetComponent<BaseUnit>();

            var randomPrefab = GetRandomUnit<BasePlayer>(Faction.Player, i+2);
            CopyUnit(randomPrefab, tempUnit);
            GetStatsFromUnit(randomPrefab);
            var spawnedPlayer = Instantiate(randomPrefab);
            var randomSpawnTile = GridManager.Instance.GetPlayerSpawnTile();
            _unitList.Add(spawnedPlayer);
            randomSpawnTile.SetUnit(spawnedPlayer);
        }

        GameManager.Instance.ChangeState(GameState.SpawnEnemies);
    }

    public void SpawnEnemies()
    {
        var heroCount = Constants.ENEMY;

        for (int i = 0; i < heroCount; i++)
        {
            var randomPrefab = GetRandomUnit<BaseEnemy>(Faction.Enemy, 1);
            var spawnedEnemy = Instantiate(randomPrefab);
            var randomSpawnTile = GridManager.Instance.GetEnemySpawnTile();
            _unitList.Add(spawnedEnemy);
            randomSpawnTile.SetUnit(spawnedEnemy);
            spawnedEnemy.OccupiedTile._enemyHighlight.SetActive(true);
        }


        GameManager.Instance.ChangeState(GameState.CalculateTurnOrder);
    }

    private T GetRandomUnit<T>(Faction faction , int i) where T : BaseUnit
    {
        //return (T)_units.Where(u => u.Faction == faction).OrderBy(o => Random.value).First().UnitPrefab;
        
        return (T)_units[i].UnitPrefab;
        
    }   


    public void SetSelectedPlayer(BasePlayer player)
    {
        SelectedPlayer = player;
        MenuManager.Instance.ShowSelectedPlayer(player);
        MenuManager.Instance.TurnStart(player);
    }

    public void SetSelectedEnemy(BaseEnemy enemy)
    {
        SelectedEnemy = enemy;
        MenuManager.Instance.ShowSelectedPlayer(enemy);
        MenuManager.Instance.TurnStart(enemy);
        //MenuManager.Instance.ShowSelectedPlayer(enemy);
    }
    
    public void SetSelectedUnit(BaseUnit unit)
    {
        SelectedUnit = unit;
    }


    public void BulletCreate(Vector3 Location)
    {
        Instantiate(Bullet, Location, Quaternion.identity);
    }

    public void EnemyBulletCreate(Vector3 Location)
    {
        Instantiate(EnemyBullet, Location, Quaternion.identity);
    }

    public void CalculateTurnOrder()
    {
        BaseUnit temp;
        
        for(int i=0;i<_unitList.Count;i++)
        {
            for(int j=_unitList.Count-1;j<i;j--)
            {
                if (_unitList[j-1].Initiative < _unitList[j].Initiative)
                {
                    temp = _unitList[j-1];
                    _unitList[j-1] = _unitList[j];
                    _unitList[j] = temp;
                }
            }
        }

        GameManager.Instance.ChangeState(GameState.TurnOrder);
    }

    public void TurnOrder()
    {
        if (_unitList[TurnNumber % _unitList.Count].Faction == Faction.Player)
        {
            SetSelectedPlayer((BasePlayer)_unitList[TurnNumber % _unitList.Count]);
        }

        if (_unitList[TurnNumber % _unitList.Count].Faction == Faction.Enemy)
        {
            SetSelectedEnemy((BaseEnemy)_unitList[TurnNumber % _unitList.Count]);
        }


        SetSelectedUnit(_unitList[TurnNumber % _unitList.Count]);
        SelectedUnit.OccupiedTile._turnHighlight.SetActive(true);
        GameManager.Instance.ChangeState(GameState.WaitState);

    }

    public void ChangeTurnOrder()
    {
        TurnNumber++;
        GameManager.Instance.ChangeState(GameState.TurnOrder);
    }

    public void CopyUnit(BasePlayer unit1, BaseUnit unit2)
    {
        unit1.UnitName = unit2.UnitName;
        unit1.Speed = unit2.Speed;
        unit1.Health = unit2.Health;
        unit1.Stamina = unit2.Stamina;
        unit1.Chi = unit2.Chi;
        unit1.Initiative = unit2.Initiative;
        unit1.PhysicalDefence = unit2.PhysicalDefence;
        unit1.ChiDefence = unit2.ChiDefence;
        unit1.Strength = unit2.Strength;
        unit1.Dexterity = unit2.Dexterity;
        unit1.Constitution = unit2.Constitution;
        unit1.Intelligence = unit2.Intelligence;
        unit1.PhysicalPower = unit2.PhysicalPower;
        unit1.ChiPower = unit2.ChiPower;
        unit1.Charisma = unit2.Charisma;
    }

    public void GetStatsFromUnit(BaseUnit unit)
    {
        healthSystem = unit.gameObject.GetComponent<HealthSystemForDummies>();
        healthSystem.MaximumHealth = unit.Health;


    }
}
