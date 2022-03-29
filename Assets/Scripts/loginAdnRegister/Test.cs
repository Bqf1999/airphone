using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    //public Button testBtn;
    //public Text nameText;
    //public InputField passwardText;

    //private const string userType = "userType";
    //private const string userName = "id";
    //private const string passward = "passward";
    //private string postUrl = "http://localhost:8080/login";

    //// Start is called before the first frame update
    //void Start()
    //{
    //    testBtn.onClick.AddListener(TestBtnEvent);
    //}
   
    //// Update is called once per frame
    //void Update()
    //{
    //    if (nameText.text.Length >= 10)
    //    {
    //        nameText.gameObject.GetComponentInParent<InputField>().readOnly = true;
    //    }
    //}

    //void TestBtnEvent()
    //{
    //    StartCoroutine("Post");
    //}

    //[System.Obsolete]
    //IEnumerator Post()
    //{
    //    //发送登录表单，每个人不一样，根据自己需要的表单参数来，一般就是账号密码，这里的userType就是管理员和员工的分类，0是管理员，1是员工。
    //    WWWForm form = new WWWForm();
        
    //    form.AddField(userName, nameText.text);
    //    form.AddField(passward, passwardText.text);
    //    Debug.Log(passwardText.text);

    //    //这里发出了登录请求
    //    //利用UnityWebRequest通过请求路径这个和postman的操作类似，将表单发送出去
    //    UnityWebRequest request = UnityWebRequest.Post(postUrl, form);
    //    yield return request.SendWebRequest();
    //    if (request.isHttpError || request.isNetworkError)
    //    {
    //        Debug.LogError(request.error);
    //    }
    //    Debug.Log(request.downloadHandler.text);
    //    Response temp = JsonUtility.FromJson<Response>(request.downloadHandler.text);
    //    Debug.Log(temp.success);
    //    Debug.Log(temp.user.userId);
        //这里获取了登录是否成功的数据
        //UnityWebRequest request2 = UnityWebRequest.Get(postUrl2);
        //yield  return request2.SendWebRequest();
        ////如果登陆失败的Session域中的id是空的，所以会报错，也就是判断登陆是否成功的依据。
        //if (request2.isHttpError || request2.isNetworkError)
        //{
        //    massage.text = "登陆失败，账号或密码错误";
        //}
        //else
        //{
        //    //反之如果登录成功则获得返回的数据，这里就是用户的id
        //    string receiveContent = request2.downloadHandler.text;
        //    //这是个普通的ui操作，我的构想是如果登录成功则将这些ui隐藏只显示massage和一个返回键
        //    foreach (GameObject ui in uis)
        //    {
        //        ui.SetActive(false);
        //    }
        //    massage.gameObject.SetActive(true);
        //    backLoginObj.SetActive(true);

        //    //如果返回的数据和用户输入时的账号一样时则判断登陆成功
        //    if (receiveContent == countText.text)
        //    {
        //        massage.text = "登陆成功，欢迎管理员" + receiveContent;
        //    }
        //    else//反之登陆失败
        //    {
        //        massage.text = "登陆失败，账号或密码错误";
        //    }
        //}
        //StopCoroutine("Post");
    //}

}
