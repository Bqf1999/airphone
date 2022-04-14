using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
public class Register : MonoBehaviour
{
    public string regUrl = "";
    public InputField accoutID;
    public InputField password;
    public Button register;
    // Start is called before the first frame update
    void Start()
    {
        register.onClick.AddListener(registerClick);
    }

    public void registerClick() {
        //用户名，密码，再次验证密码不能为空
        if (accoutID.text == "" || password.text == "")
        {
            print("请输入完整信息");
        }
        else {
            StartCoroutine("Post");
        }
        //注册成功后，跳到开始界面，跳过登陆界面，将账户密码存入本地；
        SceneManager.LoadScene("Init");
        
    }
    [System.Obsolete]
    IEnumerator Post()
    {
        print(accoutID.text);
        print(password.text);
        UserSerial user = new UserSerial(accoutID.text, password.text);
        byte[] loginByte = Encoding.UTF8.GetBytes(JsonUtility.ToJson(user));

        UnityWebRequest request = new UnityWebRequest(regUrl, "Post");

        request.uploadHandler = (UploadHandler)new UploadHandlerRaw(loginByte);
        request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        yield return request.SendWebRequest();

        if (request.isHttpError || request.isNetworkError)
        {
            if (request.responseCode == 604)
            {
                print("账号已存在");
            }


            Debug.LogError(request.responseCode);
            Debug.LogError(request.error);
        }
    }
}
