using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class PasswordValue : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void CheckPassword() {

        Regex regex =new Regex("/^(?=.*\d)(?=.*[a-zA-Z])[\da-zA-Z~!@#$%^&*]{6,8}$/");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
