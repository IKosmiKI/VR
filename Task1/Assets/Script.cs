using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Animator _anim;
    private void OnMouseDown()
    {
        _anim.SetTrigger("Start");
    }
}
