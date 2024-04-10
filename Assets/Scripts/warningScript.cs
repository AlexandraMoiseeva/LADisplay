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
    public GameObject[] warningsShow;
    public GameObject angleAngle;
    public GameObject sidingAngle;

    void Start()
    {

    }

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

        warningsShow = new GameObject[sizeWarningShow];
        int id = 0;

        for (int i = 0; i < warnings.Length; ++i)
        {
            if (warnings[i].GetComponent<Image>().color.r != Data.ourGreen.r)
            {
                warningsShow[id] = warnings[i];
                ++id;
                warnings[i].SetActive(true);
                switch (i)
                {
                    case 0:
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourOrange.r)
                            GameObject.Find("GameObject/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text 
                                = "Превышение угла атаки";
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourRed.r)
                            GameObject.Find("GameObject/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "Критическое превышение угла атаки";
                        break;
                    case 1:
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourOrange.r)
                            GameObject.Find("GameObject (2)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "Превышение угла скольжения";
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourRed.r)
                            GameObject.Find("GameObject (2)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "Критическое превышение угла скольжения";
                        break;
                    case 2:
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourOrange.r)
                            GameObject.Find("GameObject (1)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "Превышение скорости набора высоты";
                        if (warnings[i].GetComponent<Image>().color.r == Data.ourRed.r)
                            GameObject.Find("GameObject (1)/Image/Text (TMP)").GetComponent<TMPro.TextMeshProUGUI>().text
                                = "Удачи";
                        break;
                }
            }
            else
                warnings[i].SetActive(false);
        }
    }
}
