using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class player_controller : MonoBehaviour
{

	public Rigidbody body;
	private static Timer timer;
    // Start is called before the first frame update
    void Start()
    {   timer = new System.Timers.Timer();
    	timer.Interval = 3000;
        body.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
