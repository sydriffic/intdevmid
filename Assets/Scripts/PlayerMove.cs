using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float movespeed = 20f;
    public Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        //movement
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            //move y position up
            newPos.y += Time.deltaTime * movespeed;
        }
        if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            //move y position down
            newPos.y -= Time.deltaTime * movespeed;
        } 
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            //move x position down
            newPos.x -= Time.deltaTime * movespeed;
        }
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //move x position up
            newPos.x += Time.deltaTime * movespeed;
        }

        //boundaries

        /*
       if (newPos.y < -80)
        {
            newPos.y = -80;
        }
        if (newPos.y > 80)
        {
            newPos.y = 80;
        }
        if (newPos.x < -71)
        {
            newPos.x = -71;
        }
        if (newPos.x > 71)
        {
            newPos.x = 71;
        }*/
        mainCamera.transform.position = new Vector3(newPos.x, newPos.y, -10);
        transform.position = newPos;
    }
}
