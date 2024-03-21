using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeightScroll : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider heightbar;
    public Slider velocitybar;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Data.positionZ > heightbar.maxValue)
            heightbar.value = heightbar.maxValue;
        else
        {
            if (Data.positionZ < heightbar.minValue)
                heightbar.value = heightbar.minValue;
            else
                heightbar.value = Data.positionZ;
        }

        float velocity = System.MathF.Sqrt(Data.velocityX * Data.velocityX +
            Data.velocityY * Data.velocityY + Data.velocityZ * Data.velocityZ);

        if (velocity > velocitybar.maxValue)
            velocitybar.value = velocitybar.maxValue;
        else
        {
            if (velocity < velocitybar.minValue)
                velocitybar.value = velocitybar.minValue;
            else
                velocitybar.value = velocity;
        }
    }
}
