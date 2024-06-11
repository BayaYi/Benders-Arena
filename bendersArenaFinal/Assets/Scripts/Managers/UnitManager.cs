using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

static class Constants
{
    public const int HEROES = 2;
    public const int ENEMY = 3;
}
public class UnitManager : MonoBehaviour
{
    public static UnitManager Instance;

    private List<ScriptableUnit> _units;

    public BasePlayer SelectedPlayer;
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
            var randomPrefab = GetRandomUnit<BasePlayer>(Faction.Player);
            var spawnedPlayer = Instantiate(randomPrefab);
            var randomSpawnTile = GridManager.Instance.GetPlayerSpawnTile();

            randomSpawnTile.SetUnit(spawnedPlayer);
        }

        GameManager.Instance.ChangeState(GameState.SpawnEnemies);
    }

    public void SpawnEnemies()
    {
        var heroCount = Constants.ENEMY;

        for (int i = 0; i < heroCount; i++)
        {
            var randomPrefab = GetRandomUnit<BaseEnemy>(Faction.Enemy);
            var spawnedEnemy = Instantiate(randomPrefab);
            var randomSpawnTile = GridManager.Instance.GetEnemySpawnTile();

            randomSpawnTile.SetUnit(spawnedEnemy);
        }


        GameManager.Instance.ChangeState(GameState.PlayerTurn);
    }

    private T GetRandomUnit<T>(Faction faction) where T : BaseUnit
    {
        return (T)_units.Where(u=>u.Faction == faction).OrderBy(o=>Random.value).First().UnitPrefab;
    }


    public void SetSelectedPlayer(BasePlayer player)
    {
        SelectedPlayer = player;
        MenuManager.Instance.ShowSelectedPlayer(player);
    }
}
