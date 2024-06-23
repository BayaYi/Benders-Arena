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

    public Dictionary<Vector3, Tile> _tiles;
    public Dictionary<Vector3Int, Tile> _tilesInt;

    private void Awake()
    {
        Instance = this;
        _tiles = new Dictionary<Vector3, Tile>();
        _tilesInt = new Dictionary<Vector3Int, Tile>();
        
    }

    
    public void GenerateGrid()
    {
        for(int x=0;x< _width*10; x=x+10)
        {
            for( int y=0;y< _height*10; y=y+10)
            {
                var spawnedTile = Instantiate(_tilePrefab,new Vector3(x+105,0,y+105),Quaternion.identity);
                spawnedTile.name = $"Tile {x/10} {y/10}";
                spawnedTile._tileLocation = Vector3Int.FloorToInt(spawnedTile.transform.position);
                _tiles.Add(spawnedTile.transform.position, spawnedTile);
                _tilesInt.Add(Vector3Int.FloorToInt(spawnedTile.transform.position), spawnedTile);
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

    public List<Tile> GetNeighbourTiles(Tile currentTile, List<Tile> searchableTiles)
    {
        var map = GridManager.Instance._tiles;
        Dictionary<Vector3Int, Tile> tilesToSearch = new Dictionary<Vector3Int, Tile>();

        if(searchableTiles.Count > 0)
        {
            foreach(var item in searchableTiles)
            {
                tilesToSearch.Add(item._tileLocation, item);
            }
        }else
        {
            tilesToSearch = _tilesInt;
        }



        

        List<Tile> _neighbours = new List<Tile>();

        //Top
        Vector3Int locationToCheck = new Vector3Int(currentTile._tileLocation.x,
            currentTile._tileLocation.y,
            currentTile._tileLocation.z + 10
            );

        if (map.ContainsKey(locationToCheck))
        {
            _neighbours.Add(tilesToSearch[locationToCheck]);
        }
        //Bottom
        locationToCheck = new Vector3Int(currentTile._tileLocation.x,
            currentTile._tileLocation.y,
            currentTile._tileLocation.z - 10
            );

        if (map.ContainsKey(locationToCheck))
        {
            _neighbours.Add(tilesToSearch[locationToCheck]);
        }

        //Right
        locationToCheck = new Vector3Int(currentTile._tileLocation.x + 10,
            currentTile._tileLocation.y,
            currentTile._tileLocation.z
            );

        if (map.ContainsKey(locationToCheck))
        {
            _neighbours.Add(tilesToSearch[locationToCheck]);
        }

        //Left
        locationToCheck = new Vector3Int(currentTile._tileLocation.x - 10,
            currentTile._tileLocation.y,
            currentTile._tileLocation.z
            );

        if (map.ContainsKey(locationToCheck))
        {
            _neighbours.Add(tilesToSearch[locationToCheck]);
        }

        return _neighbours;
    }
}
