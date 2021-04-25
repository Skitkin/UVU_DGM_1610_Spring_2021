using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public GameObject Platform1;
    public GameObject Platform2;
    public GameObject Platform3;
    public GameObject Platform4;
    private GameObject RotationPoint;
    public float Speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        RotationPoint = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
       RotationPoint.transform.Rotate (Time.deltaTime * Speed, 0, 0);
        Platform1.transform.Rotate (Time.deltaTime * -Speed, 0, 0);
        Platform2.transform.Rotate (Time.deltaTime * -Speed, 0, 0);
        Platform3.transform.Rotate (Time.deltaTime * -Speed, 0, 0);
        Platform4.transform.Rotate (Time.deltaTime * -Speed, 0, 0);
    }
}
