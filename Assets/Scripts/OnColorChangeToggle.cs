using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColorChangeToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public FlexibleColorPicker green;
    public FlexibleColorPicker yellow;
    public FlexibleColorPicker orange;
    public FlexibleColorPicker red;
    void Start()
    {
        green.SetColor(Data.ourGreen);
        yellow.SetColor(Data.ourYellow);
        orange.SetColor(Data.ourOrange) ;
        red.SetColor(Data.ourRed);
    }
    // Update is called once per frame
    void Update()
    {
        green.SetColor(Data.ourGreen);
        yellow.SetColor(Data.ourYellow); 
        orange.SetColor(Data.ourOrange);
        red.SetColor(Data.ourRed);
    }
    public void ChangeGreen()
    {
        if (green.color == Color.red)
            green.SetColor(Data.ourGreen);
        Data.ourGreen = green.color;
        Data.Save();
    }
    public void ChangeYellow()
    {
        if (yellow.color == Color.red)
            yellow.SetColor(Data.ourYellow);
        Data.ourYellow = yellow.color;
        Data.Save();
    }
    public void ChangeOrange()
    {
        if (orange.color == Color.red)
            orange.SetColor(Data.ourOrange);
        Data.ourOrange = orange.color;
        Data.Save();
    }
    public void Changered()
    {
        if (red.color == Color.red)
            red.SetColor(Data.ourRed);
        Data.ourRed = red.color;
        Data.Save();
    }
}
