using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float PlayerSpeed;
void OnMove(Vector3 WalkPoint)
    {
        float step = PlayerSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,WalkPoint,step);
    }
}
