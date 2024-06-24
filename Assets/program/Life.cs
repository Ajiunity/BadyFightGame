using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Life : MonoBehaviour
{
    private TextMeshProUGUI number;

    private int oldN;
    public int life = 10;
    // Start is called before the first frame update
    void Start()
    {
        number = GetComponent<TextMeshProUGUI>();
        number.text = ""+life;
        oldN = life;
        
    }


    // Update is called once per frame
    void Update()
    {
        if (oldN != life)
        {
            number.text = ""+ life;
            oldN = life;

        }
    }
    public void Heal()
    {
        life += 1;
    }
    public void Damege()
    {
        life -= 1;
    }
}

