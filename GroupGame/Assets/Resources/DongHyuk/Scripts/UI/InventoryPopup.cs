using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPopup : MonoBehaviour
{
    RectTransform rectTransform;
    Vector3 hidePosition;
    public bool isShow;

    void Awake() {
        rectTransform = transform.GetComponent<RectTransform>();
    }

    void Start()
    {
        hidePosition = new Vector3(1500, 0, 0);

        rectTransform.anchoredPosition = hidePosition;
        isShow = false;
    }

    public void ChangeShow() {
        isShow = !isShow;

        if(isShow)
            rectTransform.anchoredPosition = Vector2.zero;
        else
            rectTransform.anchoredPosition = hidePosition;
    }
}
