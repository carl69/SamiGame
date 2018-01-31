using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour {

    void Update () {
        if (Input.touchCount > 1)
        {
            Application.Quit();
        }

        Debug.Log(Input.touchCount);
        	
	}
}
