using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;

    [SerializeField] float fltminSpawnDelay = 1f;
    [SerializeField] float fltmaxSpawnDelay = 5f;
    [SerializeField] Attacker attackerPrefab;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(fltminSpawnDelay, fltmaxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Attacker newAttacker = Instantiate
            (attackerPrefab, transform.position, transform.rotation)
            as Attacker;
        newAttacker.transform.parent = transform; //This basically tells the spawner what, where, when, and how (maybe not how) it is, it gives it its identity.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
