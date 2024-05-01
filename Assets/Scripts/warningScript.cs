using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class warningScript : MonoBehaviour
{
    // Start is called before the first frame update
    //angle attack
    //siding attack
    //height
    public GameObject[] warnings;
    public GameObject angleAngle;
    public GameObject sidingAngle;

    // Update is called once per frame
    void Update()
    {
        warnings[0].GetComponent<Image>().color = angleAngle.GetComponent<Image>().color;
        warnings[0].GetComponent<Image>().color = new Color(warnings[0].GetComponent<Image>().color.r,
                                                            warnings[0].GetComponent<Image>().color.g,
                                                            warnings[0].GetComponent<Image>().color.b, 1f);

        warnings[1].GetComponent<Image>().color = sidingAngle.GetComponent<Image>().color;
        warnings[1].GetComponent<Image>().color = new Color(warnings[1].GetComponent<Image>().color.r,
                                                            warnings[1].GetComponent<Image>().color.g,
                                                            warnings[1].GetComponent<Image>().color.b, 1f);

        warnings[4].GetComponent<Image>().color = System.MathF.Sqrt(Data.velocityX * Data.velocityX +
            Data.velocityY * Data.velocityY + Data.velocityZ * Data.velocityZ) < 10 ? Data.ourRed :
            System.MathF.Sqrt(Data.velocityX * Data.velocityX +
            Data.velocityY * Data.velocityY + Data.velocityZ * Data.velocityZ) < 15 ? Data.ourOrange : 
            System.MathF.Sqrt(Data.velocityX * Data.velocityX +
            Data.velocityY * Data.velocityY + Data.velocityZ * Data.velocityZ) < 20 ? Data.ourYellow : Data.ourGreen;

        warnings[2].GetComponent<Image>().color = System.Math.Abs(VelocityVisibleTriangle.velocity) < 5 ? Data.ourGreen :
            System.Math.Abs(VelocityVisibleTriangle.velocity) < 6 ? Data.ourOrange : Data.ourRed;

        warnings[3].GetComponent<Image>().color = Data.positionY < 0 ? Data.ourRed :
            System.Math.Abs(VelocityVisibleTriangle.velocity) > 3000 ? Data.ourOrange : Data.ourGreen;

        bool isColor(Color c1, Color c2)
        {
            return (c1.r == c2.r) & (c1.g == c2.g) & (c1.b == c2.b);
        }

        for (int i = 0; i < warnings.Length; ++i)
        {
            if (!isColor(warnings[i].GetComponent<Image>().color, Data.ourGreen))
            {
                warnings[i].SetActive(true);
                switch (i)
                {
                    case 0:
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourYellow))
                            GameObject.Find("GameObject/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "угл атаки";
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourOrange))
                            GameObject.Find("GameObject/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text 
                                = "угл атаки";
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourRed))
                            GameObject.Find("GameObject/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "угл атаки";
                        break;
                    case 1:
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourYellow))    
                            GameObject.Find("GameObject (2)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "угл скольжения";
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourOrange))
                            GameObject.Find("GameObject (2)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "угл скольжения";
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourRed))
                            GameObject.Find("GameObject (2)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "угл скольжения";
                        break;
                    case 2:
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourOrange))
                            GameObject.Find("GameObject (1)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "набор высоты";
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourRed))
                            GameObject.Find("GameObject (1)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "Удачи";
                        break;
                    case 3:
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourOrange))
                            GameObject.Find("GameObject (3)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "высота";
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourRed))
                            GameObject.Find("GameObject (3)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "земля";
                        break;
                    case 4:
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourYellow))
                            GameObject.Find("GameObject (4)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "скорость";
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourOrange))
                            GameObject.Find("GameObject (4)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "скорость";
                        if (isColor(warnings[i].GetComponent<Image>().color, Data.ourRed))
                            GameObject.Find("GameObject (4)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "скорость";
                        break;

                }
            }
            else
                warnings[i].SetActive(false);
        }
    }
}
