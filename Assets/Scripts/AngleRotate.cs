using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AngleRotate : MonoBehaviour
{
    public Slider mySlider;
    public TMP_InputField myField;
    int rotate;
    public GameObject at, sk;
    // Start is called before the first frame update
    void Start()
    {
        rotate = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void onSliderValueChanged()
    {
        at.transform.RotateAround(at.transform.position, Vector3.back, int.Parse(myField.text) - (int)mySlider.value);
        sk.transform.RotateAround(sk.transform.position, Vector3.back, int.Parse(myField.text) - (int)mySlider.value);
        myField.text = ((int)mySlider.value).ToString();
    }

    public void onFieldValueChanged()
    {
        if (int.Parse(myField.text) < 0)
        {
            at.transform.RotateAround(at.transform.position, Vector3.back, 0 - (int)mySlider.value);
            sk.transform.RotateAround(sk.transform.position, Vector3.back, int.Parse(myField.text) - (int)mySlider.value);
            mySlider.value = 0;
            myField.text = (0).ToString();
        }
        else
            if (int.Parse(myField.text) > 360)
            {
                at.transform.RotateAround(at.transform.position, Vector3.back, 360 - (int)mySlider.value);
                sk.transform.RotateAround(sk.transform.position, Vector3.back, int.Parse(myField.text) - (int)mySlider.value);
                mySlider.value = 360;
                myField.text = (360).ToString();
            }
            else
            {
                sk.transform.RotateAround(sk.transform.position, Vector3.back, int.Parse(myField.text) - (int)mySlider.value);
                at.transform.RotateAround(at.transform.position, Vector3.back, int.Parse(myField.text) - (int)mySlider.value);
                mySlider.value = int.Parse(myField.text);
            }
    }
}
