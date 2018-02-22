﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public float speed = 0.1f;
    public void FixedUpdate(){
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        }
		if(Input.GetKey(KeyCode.Space)){
            transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
        }
		if(Input.GetKey(KeyCode.AltGr)){
            transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
        }
    }
 }