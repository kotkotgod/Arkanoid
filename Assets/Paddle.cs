using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    float y;
    Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = v;
        //Debug.Log($"X: {v.x} Y: {v.y}");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        collider.enabled = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collider.enabled = true;
    }
}
