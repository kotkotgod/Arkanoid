using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    float y;
    // Start is called before the first frame update
    void Start()
    {
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        transform.position = new Vector2(x, y);
    }
}
