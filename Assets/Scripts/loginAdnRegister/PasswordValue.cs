using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class PasswordValue : MonoBehaviour
{

    public InputField pwd;

    public Text tips;

    public Button login;

    //Regex regex = new Regex("/^(?=.*[0-9])(?=.*[a-zA-Z])(?=.*[~!@#$%^&*])([a-zA-Z0-9~!@#$%^&*].{6,8})$/");
    //Regex regex = new Regex("/^(?![A-z0-9]+$)(?![A-z~@*()_]+$)(?![0-9~@*()_]+$)([A-z0-9~@*()_]{6,8})$/");
    //Regex regex = new Regex("^(?![\\d]+$)(?![a-zA-Z]+$)(?![^\\da-zA-Z]+$).{6,20}$");

    Regex regex = new Regex("(?=.*[0-9])(?=.*[a-zA-Z])(?=.*[^a-zA-Z0-9]).{6,8}");

    Color color;

    //验证密码的有效性，必须包含字母，数字，特殊字符三种，长度在6-8
    //无效密码||空密码，注册按钮失效 enable=false
    // Start is called before the first frame update


    void Start()
    {
        color = tips.color;
        pwd.onValueChanged.AddListener(delegate { CheckPassword(); });   
    }


    public void CheckPassword() {

        if (!regex.IsMatch(pwd.text))
        {
            login.enabled = false;
            if (pwd.text == "")
            {
                tips.color = color;
            }
            else {
                tips.color = Color.red;
            }  
        }
        else {
            login.enabled = true;
            tips.color = color;
        }
    }
}
