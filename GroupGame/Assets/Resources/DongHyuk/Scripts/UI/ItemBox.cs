using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBox : MonoBehaviour
{
    bool isFill;
    string itemName;
    Image itemImage;

    void Start()
    {  
        itemImage = transform.GetChild(0).GetComponent<Image>();

        _ClearItem();
    }

    void Update()
    {
        
    }

    public bool IsFill() {
        return isFill;
    }

    public void _FillItem() {
        isFill = true;
        itemImage.color = Color.white;
    }
    public void _ClearItem() {
        isFill = false;
        itemImage.color = Color.red;
    }
}
