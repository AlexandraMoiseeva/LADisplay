using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcome : MonoBehaviour
{
    // Start is called before the first frame update

    float timer;
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 4)
            timer += Time.deltaTime;
        else
            Application.LoadLevel("SampleScene");
    }
}
