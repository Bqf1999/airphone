using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ToRegister : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(btClick);
    }

   public void btClick() {
        //点击注册，跳到注册页面
        SceneManager.LoadScene("Register");
        
    }
}
