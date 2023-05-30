using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speed = 5;

    public SpriteRenderer sprite;

    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * speed * Time.deltaTime * horizontal);
        if(horizontal > 0)
        {
            sprite.flipX = true;
            anim.SetFloat("run", true);
        }
        else if(horizontal < 0)
        {
            sprite.flipX = false;
            anim.SetFloat("run", true);
        }
        else if(horizontal == 0)
        {
            
        }
    }
}
