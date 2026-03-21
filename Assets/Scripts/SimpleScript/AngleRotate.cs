using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AngleRotate : MonoBehaviour
{
    public Slider mySlider;
    public TMP_InputField myField;
    public GameObject at, sk;

    public GameObject centerAngleAttack;
    public GameObject targetAngleAttack;
    public GameObject centerSideAttack;
    public GameObject targetSideAttack;
    // Start is called before the first frame update

    public void onSliderValueChanged()
    {
        at.transform.RotateAround(at.transform.position, Vector3.back, int.Parse(myField.text) - (int)mySlider.value);
        if (sk.transform.rotation != at.transform.rotation)
            sk.transform.RotateAround(sk.transform.position, Vector3.back, int.Parse(myField.text) - (int)mySlider.value);
        else
            sk.transform.RotateAround(sk.transform.position, Vector3.back, -(int.Parse(myField.text) - (int)mySlider.value));
        myField.text = ((int)mySlider.value).ToString();
    }

    public void Init()
    {
        mySlider.value = 0;
        myField.text = (0).ToString();
        at.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        sk.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

        targetAngleAttack.transform.localPosition = new Vector3(0, 36.6f, 0);
        targetSideAttack.transform.localPosition = new Vector3(0, 36.6f, 0);

        targetAngleAttack.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        targetSideAttack.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

        targetAngleAttack.transform.RotateAround(centerAngleAttack.transform.position, Vector3.back, 90.0f);
        targetSideAttack.transform.RotateAround(centerSideAttack.transform.position, Vector3.back, 90.0f);

        targetAngleAttack.transform.RotateAround(centerAngleAttack.transform.position, Vector3.back, 360.0f / 40.0f * (-Data.angleAttack) / System.MathF.PI * 180.0f);
        targetSideAttack.transform.RotateAround(centerSideAttack.transform.position, Vector3.back, 360.0f / 40.0f * (-Data.sidingAttack) / System.MathF.PI * 180.0f);
    }

    public void onFieldValueChanged()
    {
        if (int.Parse(myField.text) < 0)
        {
            at.transform.RotateAround(at.transform.position, Vector3.back, 0 - (int)mySlider.value);
            if (sk.transform.rotation != at.transform.rotation)
                sk.transform.RotateAround(sk.transform.position, Vector3.back, 0 - (int)mySlider.value);
            else
                sk.transform.RotateAround(sk.transform.position, Vector3.back, -(0 - (int)mySlider.value));
            mySlider.value = 0;
            myField.text = (0).ToString();
        }
        else
            if (int.Parse(myField.text) > 360)
            {
                at.transform.RotateAround(at.transform.position, Vector3.back, 360 - (int)mySlider.value);
                if (sk.transform.rotation != at.transform.rotation)
                    sk.transform.RotateAround(sk.transform.position, Vector3.back, 360 - (int)mySlider.value);
                else
                    sk.transform.RotateAround(sk.transform.position, Vector3.back, -(360 - (int)mySlider.value));
                mySlider.value = 360;
                myField.text = (360).ToString();
            }
            else
            {
                sk.transform.RotateAround(sk.transform.position, Vector3.back, int.Parse(myField.text) - (int)mySlider.value);
                if (sk.transform.rotation != at.transform.rotation)
                    sk.transform.RotateAround(sk.transform.position, Vector3.back, int.Parse(myField.text) - (int)mySlider.value);
                else
                    sk.transform.RotateAround(sk.transform.position, Vector3.back, -(int.Parse(myField.text) - (int)mySlider.value));
                mySlider.value = int.Parse(myField.text);
            }
    }
}
