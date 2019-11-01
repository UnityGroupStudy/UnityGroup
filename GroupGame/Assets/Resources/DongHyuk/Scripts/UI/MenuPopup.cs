using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPopup : MonoBehaviour
{
    public Vector2 rectFullSizeDelta;
    public Vector2 rectSizeDelta;
    
    public RectTransform rectTransform;

    public RectTransform[] childRectTransform;

    bool isShow;
    bool isEnable;

    void Awake() {
        rectTransform = GetComponent<RectTransform>();
        childRectTransform = transform.GetComponentsInChildren<RectTransform>();
    }

    void Start()
    {
        rectFullSizeDelta = new Vector2(400, 600);
        rectSizeDelta = new Vector2(400, 0);
        rectTransform.sizeDelta = rectSizeDelta;

        isShow = false;
        isEnable = false;

        for(int i=1; i<childRectTransform.Length; i++) {
            if(i % 2 == 0) continue;
            childRectTransform[i].anchoredPosition = new Vector3(0, -((i / 2) * 150)*(rectSizeDelta.y / rectFullSizeDelta.y), 0f);
            childRectTransform[i].sizeDelta = new Vector2(400, 100f*(rectSizeDelta.y / rectFullSizeDelta.y));
        }
    }

    void Update() {
        /*if(Input.GetKeyDown(KeyCode.Escape)) {
            isEnable = !isEnable;
            isShow = true;
        }*/

        if(isShow) {
            if(isEnable)
                On();
            else
                Off();

            rectTransform.sizeDelta = rectSizeDelta;
            for(int i=1; i<childRectTransform.Length; i++) {
                if(i % 2 == 0) continue;
                childRectTransform[i].anchoredPosition = new Vector3(0, -((i / 2) * 150)*(rectSizeDelta.y / rectFullSizeDelta.y), 0f);
                childRectTransform[i].sizeDelta = new Vector2(400, 100f*(rectSizeDelta.y / rectFullSizeDelta.y));
            }
        }
    }

    public void ChangeShow() {
        isEnable = !isEnable;
        isShow = true;
    }

    void On() {
        rectSizeDelta.y = Mathf.Lerp(rectSizeDelta.y, 600, Time.deltaTime*3);
        if(rectSizeDelta.y >= 580) {
            rectSizeDelta.y = 600;
            isShow = false;
        }
    }

    void Off() {
        rectSizeDelta.y = Mathf.Lerp(rectSizeDelta.y, 0, Time.deltaTime*3);
        if(rectSizeDelta.y <= 20) {
            rectSizeDelta.y = 0;
            isShow = false;
        }
    }

}
