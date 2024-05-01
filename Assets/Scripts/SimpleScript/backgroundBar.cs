using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class backgroundBar : MonoBehaviour
{
    // Start is called before the first frame update
    float begin;
    public RawImage compassImage;

    // Update is called once per frame
    void Update()
    {
        //compassImage.uvRect = new Rect(camera.localEulerAngles.y / 360f, 0f, 1f, 1f);
        compassImage.uvRect = new Rect(0f, 1.0f / 360.0f / 2.0f * (Data.pitch) / System.MathF.PI * 180.0f, 1f, 1f);
    }
}