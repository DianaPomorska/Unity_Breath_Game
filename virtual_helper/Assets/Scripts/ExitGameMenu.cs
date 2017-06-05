using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGameMenu : MonoBehaviour {

    void OnMouseDown()
    {
        Application.LoadLevel(0);
    }
}
