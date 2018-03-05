using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private BoxCollider2D groundCollider;
    private float groundHorizontalLeft;

    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
    }

    void Start ()
    {
        groundHorizontalLeft = groundCollider.size.x;
	}

    private void RepositionBackground()
    {
        transform.Translate(Vector2.right * groundHorizontalLeft * 2);
    }
	
	void Update ()
    {
		if (transform.position.x < -groundHorizontalLeft)
        {
            RepositionBackground();
        }
	}
}
