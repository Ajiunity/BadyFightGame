using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drow: MonoBehaviour
{
    public GameObject Hand; // �ړ���̐e�I�u�W�F�N�g
    public GameObject Gage;
    void Start()
    {
       /*
        for(int i = 0; i < 3; i++)//������D
        {
            DrowFunction();
        }
       */
       
    }

    public void DrowFunction()
    {
        Debug.Log("Drow");
        
        int cCount = transform.childCount;//�q�̐�
        if (transform.childCount != 0) 
        {
            Transform child = transform.GetChild(0);
            child.SetParent(Hand.transform);
        
        }

        
    }
    public void ChageFunction()
    {
        Debug.Log("Chage");
        int cCount = transform.childCount;//�q�̐�
        if (transform.childCount != 0)
        {
            Transform child = transform.GetChild(0);
            child.SetParent(Gage.transform);

        }


    }


}
