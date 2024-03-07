using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;

public class VelocityVisibleTriangle : MonoBehaviour
{
    public GameObject[] triangles;
    private int velocity;
    private bool up;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        velocity = 0;
        up = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (up)
        {
            velocity += 1;
            if (velocity == 6)
                up = false;
        }
        else
        {
            velocity -= 1;
            if (velocity == -6)
                up = true;
        }
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
