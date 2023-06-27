using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D player;
    float horizontal;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       //Player Movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
         
    }
}
