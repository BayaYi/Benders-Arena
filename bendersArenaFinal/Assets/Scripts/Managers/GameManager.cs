using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState GameState;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        ChangeState(GameState.GenerateGrid);
    }

    public void ChangeState(GameState newState)
    {
        switch (newState)
        {
            case GameState.GenerateGrid:
                GridManager.Instance.GenerateGrid();
                break;
            case GameState.SpawnPlayer: 
                UnitManager.Instance.SpawnPlayers();
                break;
            case GameState.SpawnEnemies:
                UnitManager.Instance.SpawnEnemies();
                break;
            case GameState.CalculateTurnOrder:
                UnitManager.Instance.CalculateTurnOrder();
                break;
            case GameState.TurnOrder:
                UnitManager.Instance.TurnOrder();
                break;
            case GameState.ChangeTurnOrder:
                UnitManager.Instance.ChangeTurnOrder();
                break;
            case GameState.AttackState:
                break;
            case GameState.MoveState:
                break;
            case GameState.WaitState:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState),newState,null);
        }
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
