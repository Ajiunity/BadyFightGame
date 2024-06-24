using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ChildCount : MonoBehaviour
{
    private TextMeshProUGUI number;
    public GameObject NumberObject;//このオブジェクトの数を数える
    private int oldN;
    // Start is called before the first frame update
    void Start()
    {
        int cCount = NumberObject.transform.childCount;
        number = GetComponent<TextMeshProUGUI>();
        number.text = "" + cCount;
        oldN = cCount;
    }

    // Update is called once per frame
    void Update()
    {

        int cCount = NumberObject.transform.childCount;
        if (oldN != cCount)
        {
            number.text = "" + cCount;
            oldN = cCount;

        }
    }

}
