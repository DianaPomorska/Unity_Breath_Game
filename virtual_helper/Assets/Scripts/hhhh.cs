using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hhhh : MonoBehaviour {
    public Animation anim;

    void Start()
    {
        // Walk backwards
        anim["Walk"].speed = -1.0f;

        // Walk at double speed
        anim["Walk"].speed = 2.0f;
    }
}
