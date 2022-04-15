using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;



public class Register : MonoBehaviour
{
    private const string regUrl = "http://127.0.0.1:18081/global/register"; //声明为public，外边的值会覆盖代码里的值，string 不会同步到外边。断点调试。
    public InputField accoutID;
    public InputField password;
    public Button register;

    public bool isSuccess = false;
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
            StartCoroutine("Registe") ;
            if (isSuccess)
            {
                SceneManager.LoadScene("Init");
            }
            
        }
        //注册成功后，跳到开始界面，跳过登陆界面，将账户密码存入本地；
        
        
    }

    [System.Obsolete]
    IEnumerator Registe()
    {
        print(accoutID.text);
        print(password.text);
        UserSerial user = new UserSerial(accoutID.text, password.text);
        byte[] loginByte = Encoding.UTF8.GetBytes(JsonUtility.ToJson(user));

        UnityWebRequest request = new UnityWebRequest(regUrl, "POST");

        request.uploadHandler = (UploadHandler)new UploadHandlerRaw(loginByte);
        request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
                
        yield return request.SendWebRequest();
        print("1111111111111");
        if (request.isHttpError || request.isNetworkError)
        {
            print(request.responseCode);

            string res = ResponseStatus.Response(request.responseCode);
            print(res);

        }
        else if (request.responseCode == 200)
        {

        }
        print(request.responseCode + "    code");

    }

}
