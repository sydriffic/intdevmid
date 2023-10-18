using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer spriteRend;
    public Sprite[] sprites;
    bool switched;
    float time = 0.5f;
    void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
        switched = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            if(!switched)
            {
                spriteRend.sprite = sprites[1];
                switched = true;
                time = 0.5f;
            }
            else
            {
                spriteRend.sprite = sprites[0];
                switched = false;
                time = 0.5f;
            }
        }
        
    }
}
