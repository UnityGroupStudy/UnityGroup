using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMNG : MonoBehaviour
{
    public MenuPopup menuPopup;
    public InventoryPopup inventoryPopup;

    public Button[] btnList;

    void Start()
    {
        for(int i=0; i<transform.childCount; i++) {
            btnList = gameObject.GetComponentsInChildren<Button>();
        }

        SetCursorEnable(false);
    }


    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space)) {
            for(int i=0; i<btnList.Length; i++)
                btnList[i].interactable = !btnList[i].interactable;
        }*/

        if(Input.GetKeyDown(KeyCode.Escape)) {
            menuPopup.ChangeShow();
            if(inventoryPopup.isShow)
                inventoryPopup.ChangeShow();

            SetCursorEnable(!Cursor.visible);
        }
    }

    public void ShowInventory() {
        inventoryPopup.ChangeShow();
    }

    public void SetCursorEnable(bool isEnable) {
        if(Application.isEditor)
            return ;

        if(!isEnable) {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
