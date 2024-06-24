using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadyColl : MonoBehaviour
{
    private bool t=false;
    // Start is called before the first frame update
    public void badycoll()
    {
        if (!t)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
            t = true;

        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            t = false;
        }
            

    }
}
