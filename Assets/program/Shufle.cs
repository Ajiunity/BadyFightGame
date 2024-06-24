using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shufle : MonoBehaviour
{

    public void ShuffleChildrenOfParent(Transform parent)
    {
        List<Transform> children = new List<Transform>();

        // 子オブジェクトのリストを作成
        foreach (Transform child in parent)
        {
            children.Add(child);
        }

        // 子オブジェクトのリストをシャッフル
        ShuffleList(children);

        // 子オブジェクトを再配置
        foreach (Transform child in children)
        {
            child.SetSiblingIndex(Random.Range(0, parent.childCount));
        }
    }

    // リストをシャッフルするメソッド
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
