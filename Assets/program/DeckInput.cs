using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckInput : MonoBehaviour
{
    public GameObject parentObject; // �ړ���̐e�I�u�W�F�N�g
    void Start()
    {

        int cCount = transform.childCount;//�q�̐�
      

        for (int i = 0; i < cCount; i++)
        {
            MoveChildObjects();
        }
        
        // �e�I�u�W�F�N�g�̎q�I�u�W�F�N�g�̃��X�g���擾
        List<Transform> children = new List<Transform>();
        foreach (Transform child in transform)
        {
            children.Add(child);
        }

        // �q�I�u�W�F�N�g�̏��Ԃ��V���b�t��
        ShuffleList(children);
        
        // �V���b�t�����ꂽ���ԂɎq�I�u�W�F�N�g����ёւ�
        foreach (Transform child in children)
        {
            child.SetAsLastSibling(); // �Ō�̎q�Ƃ��ĕ��ёւ�
        }
        
    }

    // ���X�g���V���b�t������֐�
    private void ShuffleList<T>(List<T> list)
    {
      
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
       
    }
    public void MoveChildObjects()
    {

        if (transform.childCount != 0)
        {
            Transform child = transform.GetChild(0);
            child.SetParent(parentObject.transform);

        }


    }
}
