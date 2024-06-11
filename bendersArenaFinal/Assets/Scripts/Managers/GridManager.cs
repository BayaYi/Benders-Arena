using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManager : MonoBehaviour
{
    public static GridManager Instance;
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tilePrefab;

    private Dictionary<Vector3, Tile> _tiles;

    private void Awake()
    {
        Instance = this;
        _tiles = new Dictionary<Vector3, Tile>();
    }

    
    public void GenerateGrid()
    {
        for(int x=0;x< _width*10; x=x+10)
        {
            for( int y=0;y< _height*10; y=y+10)
            {
                var spawnedTile = Instantiate(_tilePrefab,new Vector3(x+105,0,y+105),Quaternion.identity);
                spawnedTile.name = $"Tile {x/10} {y/10}";

                _tiles.Add(spawnedTile.transform.position, spawnedTile);   
            }
        }
        

        GameManager.Instance.ChangeState(GameState.SpawnPlayer);
    }

    public Tile GetPlayerSpawnTile()
    {
       return _tiles.Where(t => t.Key.x < (_width / 5) + 105 && t.Value.Walkable).OrderBy(t => Random.value).First().Value;
    
    }
    public Tile GetEnemySpawnTile()
    {
        return _tiles.Where(t => t.Key.x > (_width * 4 / 5) + 105 && t.Value.Walkable).OrderBy(t => Random.value).First().Value;
    }
}
