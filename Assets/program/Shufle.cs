using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shufle : MonoBehaviour
{

    public void ShuffleChildrenOfParent(Transform parent)
    {
        List<Transform> children = new List<Transform>();

        // �q�I�u�W�F�N�g�̃��X�g���쐬
        foreach (Transform child in parent)
        {
            children.Add(child);
        }

        // �q�I�u�W�F�N�g�̃��X�g���V���b�t��
        ShuffleList(children);

        // �q�I�u�W�F�N�g���Ĕz�u
        foreach (Transform child in children)
        {
            child.SetSiblingIndex(Random.Range(0, parent.childCount));
        }
    }

    // ���X�g���V���b�t�����郁�\�b�h
    void ShuffleList<T>(List<T> list)
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

}
