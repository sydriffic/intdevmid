using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TextAppear : MonoBehaviour
{
    TMP_Text text;
    GameObject player;
    bool typing;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        typing = false;
        text.enabled = false;
        player = GameObject.Find("Player");
        if(player == null)
        {
            Debug.Log("player not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }

    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        Vector3 pPos = player.transform.position;

        
        if(Math.Abs(pos.x - pPos.x) <= 2 || Math.Abs(pos.y - pPos.y) <= 2 && !typing) 
        {
            typing = true;
            text.enabled = true;
        }
    }

}
