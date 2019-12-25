using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************
 * USED BY
 * 
 * Scripts/GamaManagement.cs
 * 
 * **********************************************/

public class DefenderSpawner : MonoBehaviour
{

    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {

        Vector2 positionInWorldUnits = GetSquareClicked();
        SpawnDefender(positionInWorldUnits);

    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickMousePosition = Input.mousePosition;

        // https://docs.unity3d.com/2018.4/Documentation/ScriptReference/Camera.ScreenToWorldPoint.html
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickMousePosition);

        return worldPosition;
    }

    private void SpawnDefender(Vector2 positionInWorldUnits)

    {
        // as GameObject at the end allows to see the instances in the hierarchy
        // transform.position is the position of the GameManagement game object
        GameObject newDefender = Instantiate(defender, positionInWorldUnits, Quaternion.identity) as GameObject;
    }
}
