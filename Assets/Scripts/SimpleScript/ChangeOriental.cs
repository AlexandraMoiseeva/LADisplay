using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOriental : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sk;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void rotate()
    {
        sk.transform.RotateAround(sk.transform.position, Vector3.up, 180.0f);
    }
}
