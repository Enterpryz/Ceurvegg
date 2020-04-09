using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    [SerializeField] int intWaitTime = 3;
    int intcurrentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        intcurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (intcurrentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(intWaitTime);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(intcurrentSceneIndex + 1);
    }
    void Update()
    {
        
    }
}
