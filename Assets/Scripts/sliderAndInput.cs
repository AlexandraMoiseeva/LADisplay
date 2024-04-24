using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class sliderAndInput : MonoBehaviour
{

    public Slider mySlider;
    public TMP_InputField myField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mySlider.value = Data.alpha;
        myField.text = Data.alpha.ToString();
    }

    public void onSliderValueChanged()
    {
        Data.alpha = (int)mySlider.value;
    }

    public void onFieldValueChanged()
    {
        if (int.Parse(myField.text) < 0)
        {
            Data.alpha = 0;
        }
        else
            if (int.Parse(myField.text) > 255)
                Data.alpha = 255;
            else
                Data.alpha = int.Parse(myField.text);
    }
}
