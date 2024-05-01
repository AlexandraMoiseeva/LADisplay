using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class exitAndRetry : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    public void Repeat(HeightScroll hs)
    {
        hs.Init();
        Data.Load();
    }
}
