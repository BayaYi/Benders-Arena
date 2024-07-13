using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState GameState;
    int i = 0;
    private void Awake()
    {
        
            Instance = this;
      
    }

    private void Start()
    {
        if (i == 0)
        {
            ChangeState(GameState.GenerateGrid);i++;
        }
    }

    public void ChangeState(GameState newState)
    {
        
        switch (newState)
        {
            case GameState.GenerateGrid:
                GridManager.Instance.GenerateGrid(); GameState = GameState.GenerateGrid;
                break;
            case GameState.SpawnPlayer: 
                UnitManager.Instance.SpawnPlayers(); GameState = GameState.SpawnPlayer;
                break;
            case GameState.SpawnEnemies:
                UnitManager.Instance.SpawnEnemies(); GameState = GameState.SpawnEnemies;
                break;
            case GameState.CalculateTurnOrder:
                UnitManager.Instance.CalculateTurnOrder(); GameState = GameState.CalculateTurnOrder;
                break;
            case GameState.TurnOrder:
                UnitManager.Instance.TurnOrder(); GameState = GameState.TurnOrder;
                break;
            case GameState.ChangeTurnOrder:
                UnitManager.Instance.ChangeTurnOrder(); GameState = GameState.ChangeTurnOrder;
                break;
            case GameState.AttackState:
                GameState = GameState.AttackState; 
                break;
            case GameState.MoveState:
                GameState = GameState.MoveState;
                break;
            case GameState.WaitState:
                GameState = GameState.WaitState;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState),newState,null);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

public enum GameState
{
    GenerateGrid = 0,
    SpawnPlayer = 1,
    SpawnEnemies = 2,
    CalculateTurnOrder = 3,
    TurnOrder = 4,
    ChangeTurnOrder = 5,
    AttackState = 6,
    MoveState = 7,
    WaitState = 8
}
