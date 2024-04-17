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
        int sizeWarningShow = 0;

        warnings[0].GetComponent<Image>().color = angleAngle.GetComponent<Image>().color;
        warnings[0].GetComponent<Image>().color = new Color(warnings[0].GetComponent<Image>().color.r,
                                                            warnings[0].GetComponent<Image>().color.g,
                                                            warnings[0].GetComponent<Image>().color.b, 1f);

        if (warnings[0].GetComponent<Image>().color.r != Data.ourGreen.r)
            ++sizeWarningShow;
        warnings[1].GetComponent<Image>().color = sidingAngle.GetComponent<Image>().color;
        warnings[1].GetComponent<Image>().color = new Color(warnings[1].GetComponent<Image>().color.r,
                                                            warnings[1].GetComponent<Image>().color.g,
                                                            warnings[1].GetComponent<Image>().color.b, 1f);

        if (warnings[1].GetComponent<Image>().color.r != Data.ourGreen.r)
            ++sizeWarningShow;

        warnings[2].GetComponent<Image>().color = System.Math.Abs(VelocityVisibleTriangle.velocity) < 5 ? Data.ourGreen :
            System.Math.Abs(VelocityVisibleTriangle.velocity) < 6 ? Data.ourOrange : Data.ourRed;

        if (warnings[2].GetComponent<Image>().color.r != Data.ourGreen.r)
            ++sizeWarningShow;

        warnings[3].GetComponent<Image>().color = Data.positionY < 0 ? Data.ourRed :
            System.Math.Abs(VelocityVisibleTriangle.velocity) > 3000 ? Data.ourOrange : Data.ourGreen;

        if (warnings[3].GetComponent<Image>().color.r != Data.ourGreen.r)
            ++sizeWarningShow;

        for (int i = 0; i < warnings.Length; ++i)
        {
            if (warnings[i].GetComponent<Image>().color.r != Data.ourGreen.r)
            {
                warnings[i].SetActive(true);
                switch (i)
                {
                    case 0:
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourYellow.r)
                            GameObject.Find("GameObject/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "угл атаки";
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourOrange.r)
                            GameObject.Find("GameObject/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text 
                                = "угл атаки";
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourRed.r)
                            GameObject.Find("GameObject/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "угл атаки";
                        break;
                    case 1:
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourYellow.r)
                            GameObject.Find("GameObject/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "угл скольжения";
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourOrange.r)
                            GameObject.Find("GameObject (2)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "угл скольжения";
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourRed.r)
                            GameObject.Find("GameObject (2)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "угл скольжения";
                        break;
                    case 2:
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourOrange.r)
                            GameObject.Find("GameObject (1)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "набор высоты";
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourRed.r)
                            GameObject.Find("GameObject (1)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "Удачи";
                        break;
                    case 3:
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourOrange.r)
                            GameObject.Find("GameObject (3)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "высота";
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourRed.r)
                            GameObject.Find("GameObject (3)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "go to hell!";
                        break;
                }
            }
            else
                warnings[i].SetActive(false);
        }
    }
}
