using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float h = 0;
    float v = 0;
    Vector2 direction;
    public float speed = 10.0f;
    Rigidbody2D rb;
    Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       h = Input.GetAxisRaw("Horizontal");
       v = Input.GetAxisRaw("Vertical");

       direction = new Vector2(h, v);

       rb.velocity = direction * speed;
    }
}
