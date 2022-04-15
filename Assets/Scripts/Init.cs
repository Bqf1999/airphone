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

    public GameObject canvasthis;

    public GameObject canvasMain;  //本地保存密码，跳此页面

    public GameObject canvasLogin; //无密码，登陆或注册

    private string mainPath = System.IO.Directory.GetCurrentDirectory();
    private string filePath = "/Assets/usr.json";


    // Start is called before the first frame update
    void Start()
    {
        login.onClick.AddListener(logClick);
    }

    public void logClick() {

        
        if (!File.Exists(mainPath + filePath))    //用户未登陆过,跳到用户登陆界面。
        {
            print("文件不存在");

            canvasthis.SetActive(false);
            canvasLogin.SetActive(true);
            
            
        }
        else
        {
            
            JsonSerial<UserSerial> jsonSerial = new JsonSerial<UserSerial>();
            jsonSerial.filePath = mainPath+filePath;
            UserSerial user = jsonSerial.readJson();
            print(user);
            if (user == null)
            {
                Debug.Log("文件为空");

                
            }
            else {
                Debug.Log("查到");
               
            }
        }
    }


}
