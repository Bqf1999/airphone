using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public InputField usr;
    public InputField pwd;
    public Button register;
    // Start is called before the first frame update
    void Start()
    {
        register.onClick.AddListener(registerClick);
    }

    public void registerClick() {
       //用户名，密码，再次验证密码不能为空

    }
   
}
