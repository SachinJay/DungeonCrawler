using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StairTrigger : MonoBehaviour
{
    public string nextLevel;

    public GameObject popUpBox;
    public Animator animator;

    public TMP_Text popUpMsg;

    //Triggered whenever stairs are entered
    private void OnTriggerEnter2D(Collider2D collision)
    {

        popUpBox.SetActive(true);
        popUpMsg.text = "pop";
        animator.SetTrigger("pop");

        //Load the next scene
        SceneManager.LoadScene(sceneName:nextLevel);

    }
}
