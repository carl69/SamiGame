﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public int hp;
    public int startHealth;
	// Use this for initialization
	void Start () {
        hp = startHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
	}
}
