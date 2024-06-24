using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    public GameObject obj;
    private bool nf = false;
    public GameObject deck;
    public GameObject list;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    public void onoff()
    {
        if (obj != null)
        {
            if (nf == false)
            {
                obj.SetActive(true);
                int n = deck.transform.childCount;
                for (int i = 0; i < n; i++)
                {
                    if (deck.transform.childCount != 0)
                    {
                        Transform child = deck.transform.GetChild(0);
                        child.SetParent(list.transform);

                    }
                }
                    

                nf = true;
            }
            else
            {
                obj.SetActive(false);
                int n = list.transform.childCount;
                for (int i = 0; i < n; i++)
                {
                    if (list.transform.childCount != 0)
                    {
                        Transform child = list.transform.GetChild(0);
                        child.SetParent(deck.transform);

                    }
                }
                nf = false;
            }
        }
       
    }
}
