using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CompassBar : MonoBehaviour
{
    // Start is called before the first frame update
    float begin;
    public RawImage compassImage;

    void Start()
    {
        begin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //compassImage.uvRect = new Rect(camera.localEulerAngles.y / 360f, 0f, 1f, 1f);
        compassImage.uvRect = new Rect(begin/1000, 0f, 1f, 1f);
        begin += 1;
        if (begin == 1000)
            begin = 0;
    }
}
