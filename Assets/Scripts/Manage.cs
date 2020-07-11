using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manage : MonoBehaviour
{
    public Transform player;
    public float initX;
    public float initY;
    // Start is called before the first frame update
    void Start()
    {
        player.SetPositionAndRotation(new Vector3(initX, initY, 0), new Quaternion());        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
