using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckInput : MonoBehaviour
{
    public GameObject parentObject; // 移動先の親オブジェクト
    void Start()
    {

        int cCount = transform.childCount;//子の数
      

        for (int i = 0; i < cCount; i++)
        {
            MoveChildObjects();
        }
        
        // 親オブジェクトの子オブジェクトのリストを取得
        List<Transform> children = new List<Transform>();
        foreach (Transform child in transform)
        {
            children.Add(child);
        }

        // 子オブジェクトの順番をシャッフル
        ShuffleList(children);
        
        // シャッフルされた順番に子オブジェクトを並び替え
        foreach (Transform child in children)
        {
            child.SetAsLastSibling(); // 最後の子として並び替え
        }
        
    }

    // リストをシャッフルする関数
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
