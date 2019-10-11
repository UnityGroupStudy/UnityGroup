using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBar : MonoBehaviour
{
    public int maxValue;
    public int value;
    public Vector2 rectFullSizeDelta;
    public Vector2 rectSizeDelta;
    
    public RectTransform rectTransform;
    public Transform backTransform;
    public RectTransform backRectTransform;

    void Awake() {
        rectTransform = GetComponent<RectTransform>();

        backTransform = transform.GetChild(0);
        backRectTransform = backTransform.GetComponent<RectTransform>();
    }

    void Start()
    {
        rectFullSizeDelta = rectTransform.sizeDelta;
        rectSizeDelta = rectFullSizeDelta;
        backRectTransform.sizeDelta = rectSizeDelta;

        maxValue = 100;
        value = 100;
    }

    void Update() {
        if(Input.GetKey(KeyCode.UpArrow))
            SetValue(value + 1);
        if(Input.GetKey(KeyCode.DownArrow))
            SetValue(value - 1);
    }

    public void SetValue(int value) {
        this.value = value;
        
        rectSizeDelta.y = rectFullSizeDelta.y * ((float)value / (float)maxValue);

        if(rectSizeDelta.y >= rectFullSizeDelta.y)
            rectSizeDelta.y = rectFullSizeDelta.y;
        if(rectSizeDelta.y < 0)
            rectSizeDelta.y = 0;
            
        backRectTransform.sizeDelta = rectSizeDelta;
    }
}
