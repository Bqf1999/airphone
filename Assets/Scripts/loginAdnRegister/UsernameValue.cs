using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class UsernameValue : MonoBehaviour
{
    public InputField usr;
    public Text text;
    public const string username = "username";

    private const string url = "";
    // Start is called before the first frame update
    void Start()
    {
        usr.onValueChanged.AddListener(delegate {UsrExist();});
    }

    public void UsrExist()
    {

        //StartCoroutine("Post");

    }


    //[System.Obsolete]
    //IEnumerator Post()
    //{
    //    //发送登陆表单
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
    // }
}
