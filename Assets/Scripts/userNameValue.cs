using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class userNameValue : MonoBehaviour
{
    public InputField username;
    // Start is called before the first frame update
    void Start()
    { 
        username.onValueChanged.AddListener(delegate{ValueChangeCheck(); });
    }

    public void ValueChangeCheck() {

        username.text = Regex.Replace(username.text, @"[^0-9]|[^a-z]|[^A-Z]", "");
        Debug.Log("非法字符");
    }
}
