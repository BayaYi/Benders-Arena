using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem : MonoBehaviour
{
    
    public struct Grids {
        public GameObject Grid;
        public bool LCheck;
        public bool RCheck;
        public bool UCheck;
        public bool DCheck;

        public Grids(GameObject grid, bool lCheck = false, bool rCheck = false, bool uCheck = false, bool dCheck = false)
        {
            Grid = grid;
            LCheck = lCheck;
            RCheck = rCheck;
            UCheck = uCheck;
            DCheck = dCheck;
        }
    };

    Grids[,] GridList = new Grids[10, 10];
    Grids[,] RGridList = new Grids[10, 10];
    
    public void AssignGrid()
    {
        for (int i = 0;i<9;i++)
            for (int j = 0; j < 9; j++) { }
                
    }
    

     
}
