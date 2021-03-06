﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************
 * USED BY
 * 
 * Scripts/GameManagement.cs
 * 
 * **********************************************/

public class DefenderSpawner : MonoBehaviour
{

    Defender defender;
    int costDefender = 100;

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void OnMouseDown()
    {

        Vector2 positionInWorldUnits = GetSquareClicked();
        CheckIfDefenderCanBeSpawn(positionInWorldUnits);

    }

    private void CheckIfDefenderCanBeSpawn(Vector2 positionInWorldUnits)
    {
        StarManager starManager = FindObjectOfType<StarManager>();
        if (starManager.GetCurrentNumberOfStars() >= costDefender)
        {
            SpawnDefender(positionInWorldUnits);
        }
    }


    private Vector2 GetSquareClicked()
    {
        Vector2 clickMousePosition = Input.mousePosition;

        // https://docs.unity3d.com/2018.4/Documentation/ScriptReference/Camera.ScreenToWorldPoint.html
        Vector2 roundedPos = Camera.main.ScreenToWorldPoint(clickMousePosition);
        Vector2 gridPosition = SnapDefenderToGrid(roundedPos);
        return gridPosition;
    }

    private Vector2 SnapDefenderToGrid(Vector2 defenderPositionInScreenPoints)
    {
        float xPosInWorldPoints = Mathf.RoundToInt(defenderPositionInScreenPoints.x);
        float yPosInWorldPoints = Mathf.RoundToInt(defenderPositionInScreenPoints.y);
        return new Vector2(xPosInWorldPoints, yPosInWorldPoints);
    }

    private void SpawnDefender(Vector2 roundedPos)

    {
        // as GameObject at the end allows to see the instances in the hierarchy
        // transform.position is the position of the GameManagement game object
        Defender newDefender = Instantiate(defender, roundedPos, Quaternion.identity);
        defender.SpendStars(costDefender);
    }
}
