using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Transform player;
    private bool isRight;
    private bool isLeft;
    private bool isUp;
    private bool isDown;
    public float step = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        float move = 0f;

        isRight = Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow);
        isLeft = Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow);
        isUp = Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow);
        isDown = Input.GetKeyDown("s") || Input.GetKeyDown(KeyCode.DownArrow);

        if (isRight || isUp) move = step;

        if (isLeft || isDown) move = -1 * step;


        if (isRight || isLeft)
        {
            player.Translate(move, 0f, 0f);
        }

        else if (isUp || isDown)
        {
            player.Translate(0f, move, 0f);
        }

        
    }
}
