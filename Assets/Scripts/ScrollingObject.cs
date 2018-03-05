using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{

    private Rigidbody2D rbd2d;


    private void Awake()
    {
        rbd2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rbd2d.velocity = new Vector2(GameController.instance.scrollSpeed, 0);
        // rbd2d.velocity = Vector2.right * GameController.instance.scrollSpeed;
    }

    void Update()
    {
        if (GameController.instance.gameOver)
        {
            rbd2d.velocity = Vector2.zero;
        }
    }
}
