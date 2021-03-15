using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    private GameObject Cam;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        Cam = gameObject;
        offset = Cam.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Cam.transform.position = new Vector3(offset.x, Player.transform.position.y, Player.transform.position.z);  
    }
}
