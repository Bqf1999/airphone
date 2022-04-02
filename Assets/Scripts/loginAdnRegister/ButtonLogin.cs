using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class ButtonLogin : MonoBehaviour
{

    public Button buttonlogin;

    public const string username = "username";


    // Start is called before the first frame update
    void Start()
    {
        buttonlogin.onClick.AddListener(ButLogin);
    }

    public void ButLogin() {

        //访问服务端，检验


        //StartCoroutine("Post");





        //正确，保存进本地



             //跳到canvas1



        //不正确



            //清空，
    }

    public void save(UserSerial user,string path) {

        JsonSerial<UserSerial> json = new JsonSerial<UserSerial>();
        json.user = user;
        json.filePath = path;
        json.saveJson();

    }



    //[System.Obsolete]
    //IEnumerator Post()
    //{
    //    发送登陆表单
    //    WWWForm form = new WWWForm();
    //    form.AddField(username, usr.text);
    //    UnityWebRequest request = UnityWebRequest.Post(url, form);
    //    yield return request.SendWebRequest();
    //    if (request.isHttpError || request.isNetworkError)
    //    {
    //        Debug.Log(request.error);
    //    }
    //    Response tmp = JsonUtility.FromJson<Response>(request.downloadHandler.text);
    //    Debug.Log(tmp.success);
    //}

}
