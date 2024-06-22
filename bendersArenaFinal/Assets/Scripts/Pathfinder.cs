using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pathfinder 
{
    public List<Tile> FindPath(Tile start, Tile end, List<Tile> searchableTiles)
    {
        List<Tile> openList = new List<Tile>();
        List<Tile> closeList = new List<Tile>();


        openList.Add(start);

        while(openList.Count > 0)
        {
            Tile currentTile = openList.OrderBy(x  => x.F).First();


            openList.Remove(currentTile);
            closeList.Add(currentTile);

            if(currentTile == end)
            {
                //finalize our path
                return GetFinishedList(start,end);

            }

            var neighbourTiles = GridManager.Instance.GetNeighbourTiles(currentTile, searchableTiles);

            foreach( var neighbour in neighbourTiles )
            {
                if( !(neighbour._isWalkable) || closeList.Contains(neighbour) ) {
                    continue;
                }

                neighbour.G = GetManhattanDistance(start, neighbour);
                neighbour.H = GetManhattanDistance(end, neighbour);

                neighbour._previous = currentTile;

                if (!openList.Contains(neighbour))
                {
                    openList.Add(neighbour);
                }
            }
        }
        return new List<Tile>();
    }

    private List<Tile> GetFinishedList(Tile start, Tile end)
    {
        List<Tile> finishedList = new List<Tile>();

        Tile _currentTile = end;
        while(_currentTile != start) {
            finishedList.Add(_currentTile);
            _currentTile = _currentTile._previous;
        }

        finishedList.Reverse();

        return finishedList;
    }

    private int GetManhattanDistance(Tile start, Tile neighbour)
    {
        return Mathf.Abs(start._tileLocation.x - neighbour._tileLocation.x) + Mathf.Abs(start._tileLocation.z - neighbour._tileLocation.z);
    }

    
}
