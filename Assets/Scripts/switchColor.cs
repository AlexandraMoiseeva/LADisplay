using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class switchColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Image>().color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        float date = Data.angleAttack / System.MathF.PI * 180.0f;
        if (System.MathF.Abs(date) > 10)
            this.GetComponent<Image>().color = new Color(Data.ourRed.r, Data.ourRed.g, Data.ourRed.b, 255.0f / 255);
        else
            if (System.MathF.Abs(date) > 7)
                this.GetComponent<Image>().color = new Color(Data.ourYellow.r, Data.ourYellow.g, Data.ourYellow.b, 150.0f / 255);
            else
                if (System.MathF.Abs(date) > 0)
                    this.GetComponent<Image>().color = new Color(Data.ourGreen.r, Data.ourGreen.g, Data.ourGreen.b, 60.0f/255);
    }
}
