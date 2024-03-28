using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;

public class VelocityVisibleTriangle : MonoBehaviour
{
    public GameObject[] triangles;
    int velocity;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        velocity = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocity = (int)Data.velocityY;
        if (velocity > 6)
            velocity = 6;
        if (velocity < -6)
            velocity = -6;
        text.text = velocity.ToString();
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
                for (int i = 6-velocity; i < 6; i++)
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
