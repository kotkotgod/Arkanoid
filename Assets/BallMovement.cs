using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Vector2 direction;
    ContactPoint2D point;
    Vector3 startingPosition;

    void Start()
    {
        direction = new Vector2(1, 1).normalized;
        //points = new ContactPoint2D[3];
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(direction * speed * Time.deltaTime);
        if (Input.GetKeyDown("space")) 
        {
            transform.position = startingPosition;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        point = collision.GetContact(0);
        //Debug.Log(point.normal.x);
        direction = Vector2.Reflect(direction, point.normal);
    }
}
