using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Attack : MonoBehaviour
{
    public bool Stand=true;
    private HorizontalLayoutGroup horizontalLayoutGroup;
    // Start is called before the first frame update
    void Start()
    {
        // HorizontalLayoutGroupコンポーネントを取得
        horizontalLayoutGroup = GetComponent<HorizontalLayoutGroup>();
    }
        public void RestStand()
    {
        Debug.Log("Pless Buttun");
        if (horizontalLayoutGroup != null)
        {
            if (Stand)
            {
                //horizontalLayoutGroup.enabled=false;
                transform.rotation = Quaternion.Euler(0f, 0f, 90f);
                //horizontalLayoutGroup.enabled=true;
                Stand = false;
            }
            else
            {
                //horizontalLayoutGroup.enabled=false;
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                //horizontalLayoutGroup.enabled=true;

                Stand = true;

            }
        }
        else
        {
            Debug.Log("ないよ！");
        }
    }
 
}
