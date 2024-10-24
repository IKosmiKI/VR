using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sch : MonoBehaviour
{
    public int x = 0;
    public Text Props;
    public GameObject ToGreen;
    public GameObject Part1;

    void Start()
    {

    }

    void FixedUpdate()
    {
        x++;
        if (x <= 100)
        {
            Props.text = x.ToString();
        }
        if (x == 100)
        {
            ToGreen.GetComponent<Renderer>().material.color = Color.red;
            Part1.SetActive(true);
        }

    }
}
