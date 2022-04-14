using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PasswordAgain : MonoBehaviour
{
    public InputField pwd;
    public InputField pwdAgain;
    public Button register;
    //确认输入密码，若前后两次输入不一致，清空输入框
    //注册按钮失效
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void isSame() {
        if (pwd.text != pwdAgain.text)
        {

            pwdAgain.text = "";
            register.enabled = false;
        }
        else
        {
            register.enabled = true;
        }
    }
    
}
