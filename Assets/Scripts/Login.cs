using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField username;
    public InputField password;
    // Start is called before the first frame update
    public void OnButton()
    {
        string usr = username.text;
        string pwd = password.text;
        Debug.Log(usr);
        Debug.Log(pwd);
    }
}
