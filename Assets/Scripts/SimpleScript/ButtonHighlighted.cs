using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonHighlighted : Selectable
{
    BaseEventData baseEvent;
    public GameObject button;
    private void Update()
    {
        if (IsHighlighted() == true)
        {
            button.SetActive(true);
        }
        else
        {
            button.SetActive(false);
        }
    }
}
