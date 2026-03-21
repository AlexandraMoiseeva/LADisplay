using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleVisible : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject signs;
    public void OnClick()
    {
        if (signs.activeSelf == false)
            signs.SetActive(true);
        else
            signs.SetActive(false);
    }
}
