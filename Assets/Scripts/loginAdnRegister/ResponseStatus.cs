using UnityEngine;
using System.Collections;

public class ResponseStatus : MonoBehaviour
{
    //public static long sucess = 200;
    //public static long illegal = 601;
    //public static long exist = 602;
    //public static long wrong = 701;
    //public static long nonexist = 703;

    
    

    public static void Response(long res) {

        switch (res) {

            case 200:
                
                break;
            case 601:
                
                break;
            case 602:
               
                break;
            case 701:
                
                break;
            case 703:
                
                break;
            default:
                break;
        }
    }
}
