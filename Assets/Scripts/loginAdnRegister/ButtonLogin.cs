using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Text;
public class ButtonLogin : MonoBehaviour
{
    

    public Button buttonlogin;

    public InputField accoutID;
    public InputField password;

    public GameObject gmthis;
    public GameObject gmmain;



    private const string loginUrl = "http://127.0.0.1:18081/global/login";

    // Start is called before the first frame update
    void Start()
    {
        buttonlogin.onClick.AddListener(ButLogin);
        
    }

    public void ButLogin() {

        //访问服务端，检验


        StartCoroutine("Post");

        
        //SceneManager.LoadScene("Init");



        //正确，保存进本地



        //跳到canvas1



        //不正确



        //清空，
    }

    //public void save(UserSerial user,string path) {

    //    JsonSerial<UserSerial> json = new JsonSerial<UserSerial>();
    //    json.user = user;
    //    json.filePath = path;
    //    json.saveJson();

    //}



    [System.Obsolete]
    IEnumerator Post()
    {
        print(accoutID.text);
        print(password.text);
        UserSerial user = new UserSerial(accoutID.text, password.text);
        byte[] loginByte = Encoding.UTF8.GetBytes(JsonUtility.ToJson(user));

        UnityWebRequest request = new UnityWebRequest(loginUrl, "Post");
        
        request.uploadHandler = (UploadHandler)new UploadHandlerRaw(loginByte);
        request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type","application/json");

        yield return request.SendWebRequest();
        print("1111111111111");
        if (request.isHttpError || request.isNetworkError)
        {
            print(request.responseCode);

           string res= ResponseStatus.Response(request.responseCode);
            print(res);

        }
        else if (request.responseCode == 200)
        {

        }
        print(request.responseCode + "    code");

    }
    
}
