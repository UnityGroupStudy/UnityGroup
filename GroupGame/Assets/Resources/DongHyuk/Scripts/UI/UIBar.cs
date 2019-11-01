using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour
{
    public int maxValue;
    public int value;

    public Image image;
    public Transform backTransform;

    void Awake() {
        backTransform = transform.GetChild(0);
        image = backTransform.GetComponent<Image>();
    }

    void Start()
    {
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
        this.value = Mathf.Clamp(value, 0, 100);
        
        image.fillAmount = ((float)this.value / (float)maxValue);
    }
}
