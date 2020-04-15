﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenderspawn : MonoBehaviour
{
    Defender GOdefender;
   
    
    private void OnMouseDown()
    {
        DeployDef(GetSquareClicked());
    }

    public void SetSelectedDefender(Defender defenderToSelect) 
    {
        GOdefender = defenderToSelect;
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }


    private void DeployDef(Vector2 roundedPos)
    {
        Defender GODefnew = Instantiate(GOdefender, roundedPos, Quaternion.identity) as Defender;
        Debug.Log(roundedPos);
    }






}
