using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;
    public GameObject GC;


    private void Awake()
    {
        GC = GameObject.Find("GameController");
        //target = GC.GetComponent<gameController>().ActivePlayer;
    }
    void Update()
    {
        target = GC.GetComponent<gameController>().activePlayer.transform;
        Vector3 goalPos = target.position;
        goalPos.y = transform.position.y;
        transform.position = Vector3.SmoothDamp(transform.position, goalPos, ref velocity, smoothTime);
    }
}