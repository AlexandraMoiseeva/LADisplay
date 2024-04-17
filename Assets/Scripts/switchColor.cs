using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class switchColor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject angleAttack;
    public GameObject sidingAttack;
    public GameObject height;
    public GameObject heightVelocity;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float date = System.MathF.Abs(Data.angleAttack / System.MathF.PI * 180.0f);
        if (System.MathF.Abs(date) > 10)
            angleAttack.GetComponent<Image>().color = new Color(Data.ourRed.r, Data.ourRed.g, Data.ourRed.b, 255.0f / 255);
        else
            if (System.MathF.Abs(date) > 7)
                angleAttack.GetComponent<Image>().color = new Color(Data.ourYellow.r, Data.ourYellow.g, Data.ourYellow.b, 150.0f / 255);
            else
                if (System.MathF.Abs(date) > 0)
                    angleAttack.GetComponent<Image>().color = new Color(Data.ourGreen.r, Data.ourGreen.g, Data.ourGreen.b, 60.0f/255);

        float date1 = System.MathF.Abs(Data.sidingAttack / System.MathF.PI * 180.0f);
        if (System.MathF.Abs(date1) > 10)
            sidingAttack.GetComponent<Image>().color = new Color(Data.ourRed.r, Data.ourRed.g, Data.ourRed.b, 255.0f / 255);
        else
            if (System.MathF.Abs(date1) > 7)
                sidingAttack.GetComponent<Image>().color = new Color(Data.ourYellow.r, Data.ourYellow.g, Data.ourYellow.b, 150.0f / 255);
            else
                if (System.MathF.Abs(date1) > 0)
                    sidingAttack.GetComponent<Image>().color = new Color(Data.ourGreen.r, Data.ourGreen.g, Data.ourGreen.b, 60.0f / 255);

        float date2 = Data.positionY;
        if (date2 < 0)
            height.GetComponent<Image>().color = new Color(Data.ourRed.r, Data.ourRed.g, Data.ourRed.b, 135.0f / 255);
        else
            if (System.MathF.Abs(date2) > 3000)
                height.GetComponent<Image>().color = new Color(Data.ourRed.r, Data.ourRed.g, Data.ourRed.b, 135.0f / 255);
            else
                height.GetComponent<Image>().color = new Color(Data.ourGreen.r, Data.ourGreen.g, Data.ourGreen.b, 135.0f / 255);

        float date3 = Data.velocityY;
        if (System.MathF.Abs(date3) > 20)
            heightVelocity.GetComponent<Image>().color = new Color(Data.ourRed.r, Data.ourRed.g, Data.ourRed.b, 135.0f / 255);
        else
            if (System.MathF.Abs(date3) > 12)
                heightVelocity.GetComponent<Image>().color = new Color(Data.ourOrange.r, Data.ourOrange.g, Data.ourOrange.b, 135.0f / 255);
            else
                if (System.MathF.Abs(date3) > 0)
                    heightVelocity.GetComponent<Image>().color = new Color(Data.ourGreen.r, Data.ourGreen.g, Data.ourGreen.b, 135.0f / 255);
    }
}
