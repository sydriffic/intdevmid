using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TextAppear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 pos = transform.position;
        Vector3 pPos = player.transform.position;

        
        /*if(Math.Abs(pos.x - pPos.x) <= 2 || Math.Abs(pos.y - pPos.y) <= 2) 
        {
            text.gameObject.SetActive(true);
        }*/
    
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger entered");
        if(col.gameObject.name == "Player")
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);  
        }
    }
}
