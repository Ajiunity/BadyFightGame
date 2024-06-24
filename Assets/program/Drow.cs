using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drow: MonoBehaviour
{
    public GameObject Hand; // 移動先の親オブジェクト
    public GameObject Gage;
    void Start()
    {
       /*
        for(int i = 0; i < 3; i++)//初期手札
        {
            DrowFunction();
        }
       */
       
    }

    public void DrowFunction()
    {
        Debug.Log("Drow");
        
        int cCount = transform.childCount;//子の数
        if (transform.childCount != 0) 
        {
            Transform child = transform.GetChild(0);
            child.SetParent(Hand.transform);
        
        }

        
    }
    public void ChageFunction()
    {
        Debug.Log("Chage");
        int cCount = transform.childCount;//子の数
        if (transform.childCount != 0)
        {
            Transform child = transform.GetChild(0);
            child.SetParent(Gage.transform);

        }


    }


}
