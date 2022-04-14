using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togame : MonoBehaviour
{
    public GameObject canvas;

    public GameObject game;
    private void Start()
    {
        game.active = false;
    }
    public void OnClick()
    {
        canvas.active = false;
        game.active = true;
    }
}
