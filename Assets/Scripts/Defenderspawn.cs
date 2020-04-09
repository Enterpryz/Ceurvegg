using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenderspawn : MonoBehaviour
{
    [SerializeField] GameObject GOdefender;
    
    private void OnMouseDown()
    {
        DeployDef(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return worldPos;
    }



    private void DeployDef(Vector2 worldPos)
    {
        GameObject GODefnew = Instantiate(GOdefender, worldPos, Quaternion.identity) as GameObject;
    }






}
