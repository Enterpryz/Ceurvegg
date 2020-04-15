using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefselUI : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefselUI>();
        foreach (DefselUI button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }
        
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<Defenderspawn>().SetSelectedDefender(defenderPrefab);
    }








}
