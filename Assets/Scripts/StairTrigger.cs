using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StairTrigger : MonoBehaviour
{
    public string nextLevel;

    //Triggered whenever stairs are entered
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Load the next scene
        SceneManager.LoadScene(sceneName:nextLevel);

    }
}
