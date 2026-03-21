using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VelocityVisibleTriangle : MonoBehaviour
{
    public GameObject[] triangles;
    int velocityV;
    static public int velocity;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        velocityV = 0;
        velocity = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        triangles[0].GetComponent<Image>().color = Data.ourRed;
        triangles[1].GetComponent<Image>().color = Data.ourOrange;
        triangles[2].GetComponent<Image>().color = Data.ourYellow;
        triangles[3].GetComponent<Image>().color = Data.ourYellow;
        triangles[4].GetComponent<Image>().color = Data.ourGreen;
        triangles[5].GetComponent<Image>().color = Data.ourGreen;

        triangles[12].GetComponent<Image>().color = Data.ourRed;
        triangles[11].GetComponent<Image>().color = Data.ourOrange;
        triangles[10].GetComponent<Image>().color = Data.ourYellow;
        triangles[9].GetComponent<Image>().color = Data.ourYellow;
        triangles[8].GetComponent<Image>().color = Data.ourGreen;
        triangles[7].GetComponent<Image>().color = Data.ourGreen;

        velocityV = (int)Data.velocityY;
        velocity = 0;

        if (velocityV > 20 && velocity == 0)
            velocity = 6;
        if (velocityV < -20 && velocity == 0)
            velocity = -6;

        if (velocityV > 12 && velocity == 0)
            velocity = 5;
        if (velocityV < -12 && velocity == 0)
            velocity = -5;

        if (velocityV > 9 && velocity == 0)
            velocity = 4;
        if (velocityV < -9 && velocity == 0)
            velocity = -4;

        if (velocityV > 5 && velocity == 0)
            velocity = 3;
        if (velocityV < -5 && velocity == 0)
            velocity = -3;

        if (velocityV > 3 && velocity == 0)
            velocity = 2;
        if (velocityV < -3 && velocity == 0)
            velocity = -2;

        if (velocityV > 0 && velocity == 0)
            velocity = 1;
        if (velocityV < -0 && velocity == 0)
            velocity = -1;

        text.text = ((int)Data.velocityY).ToString();
        for (int i = 0; i < triangles.Length; i++)
        {
            if (i == 6)
                continue;
            triangles[i].SetActive(false);
        }
        if (velocity != 0)
        {
            if (velocity > 0)
            {
                for (int i = 6 - velocity; i < 6; i++)
                {
                    triangles[i].SetActive(true);
                }
            }
            else
            {
                for (int i = 7; i < 7-velocity; i++)
                {
                    triangles[i].SetActive(true);
                }
            }
        }
    }
}
