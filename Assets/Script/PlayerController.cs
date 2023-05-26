using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speed = 5;

    public SpriteRenderer sprite;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * speed * Time.deltaTime * horizontal);
        if(horizontal == 1)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }
    }
}
