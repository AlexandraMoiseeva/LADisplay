using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextSlider : MonoBehaviour
{
    public Slider slider;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TMPro.TextMeshProUGUI>().text = slider.value.ToString();
    }
}
