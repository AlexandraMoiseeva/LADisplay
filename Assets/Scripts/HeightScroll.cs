using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightScroll : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider heightbar;
    float amount;
    bool direct;
    void Start()
    {
        amount = 0;
        direct = true;
    }

    // Update is called once per frame
    void Update()
    {
        heightbar.value = amount/100 * (heightbar.maxValue - heightbar.minValue);
        if (direct == true)
            amount += 1;
        else
            amount -= 1;
        if (amount == 100)
            direct = false;
        if (amount == 0)
            direct = true;
    }
}
