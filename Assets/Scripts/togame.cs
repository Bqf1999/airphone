using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togame : MonoBehaviour
{
    public GameObject canvas;

    public GameObject game;
    private void Start()
    {
        
        game.SetActive(false);
    }
    public void OnClick()
    {
        canvas.SetActive(false);
        game.SetActive(true);
    }
}
