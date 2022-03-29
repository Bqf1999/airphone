using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Init : MonoBehaviour
{
    //挂载到登陆游戏按钮上
    //本地保存用户名密码，直接验证登陆
    //无文件，创建文件。跳转到登陆窗口


    public Button login;

    private string mainPath = System.IO.Directory.GetCurrentDirectory();
    private string filePath = "/Assets/usr.txt";
    // Start is called before the first frame update
    void Start()
    {
        login.onClick.AddListener(logClick);

    }

    public void logClick() {

        if (!File.Exists(mainPath + filePath))
        {
            File.CreateText(mainPath + filePath);
        }
        else
        {
            StreamReader sr = File.OpenText(mainPath + filePath);
            string s = sr.ReadLine();
            if (s.Length != 0)
            {
                string[] args = s.Split(' ');
                if (true)
                {
                    //SceneManager.LoadScene();//跳到canvs1
                }
            }
            else
            {
                SceneManager.LoadScene("Login");
            }

        }
    }


}
