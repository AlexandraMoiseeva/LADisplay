using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoStandart : MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle t;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(AngleRotate ar)
    {
        t.isOn = false;
        Data.InitValue();
        ar.Init();
    }
}
