using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToolTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TextMeshProUGUI view;
    [SerializeField] private string text;

    public void OnPointerEnter(PointerEventData eventData)
    {
        view.text = text;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        view.text = String.Empty;

    }
}
