using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{   
    public GameObject itemBoxPrefab;
    public List<ItemBox> itemBoxList;

    void Start()
    {
        for(int i=0; i<7 * 5; i++) {
            RectTransform newItemBox = Instantiate(itemBoxPrefab, Vector3.zero, Quaternion.identity, transform).GetComponent<RectTransform>();
            newItemBox.anchoredPosition = new Vector3(i%7 * 150, -i/7 * 150, 0);
            itemBoxList.Add(newItemBox.GetComponent<ItemBox>());
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)) {
            int index = 0;
            while(itemBoxList[index].IsFill())
                index+=1;
            itemBoxList[index]._FillItem();
        }
    }
}
