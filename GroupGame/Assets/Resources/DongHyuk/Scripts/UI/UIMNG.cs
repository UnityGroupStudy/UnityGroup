using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMNG : MonoBehaviour
{
    public Button[] btnList;

    void Start()
    {
        for(int i=0; i<transform.childCount; i++) {
            btnList = gameObject.GetComponentsInChildren<Button>();
        }
    }


    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space)) {
            for(int i=0; i<btnList.Length; i++)
                btnList[i].interactable = !btnList[i].interactable;
        }*/
    }
}
