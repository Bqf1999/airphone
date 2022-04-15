using UnityEngine;
using System.Collections;

public class ResponseStatus : MonoBehaviour
{
    //public static long sucess = 200;
    //public static long illegal = 601;
    //public static long exist = 602;
    //public static long wrong = 701;
    //public static long nonexist = 703;

    
    

    public static string Response(long str) {
        string res = "";
        switch (str) {

            case 200:
                res += "通过";
                break;
            case 601:
                res += "不合法的账号或者密码";
                break;
            case 602:
                res += "账号已经存在";
                break;
            case 701:
                res += "密码错误";
                break;
            case 703:
                res += "账号不存在";
                break;
            default:
                break;
        }
        return res;
    }
}
