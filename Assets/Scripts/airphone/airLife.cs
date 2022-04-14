using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class airLife : MonoBehaviour
{
    public  static float  life=100; //飞机生命

    public  static int score = 0;  //得分

    

   

    public GameObject baozha; //飞机爆炸播放的动画。
     
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bul"))
        {
            return;
        }
        string name = collision.gameObject.name;
        
        switch (name)
        {
            case "3(Clone)":
            case "6(Clone)":
            case "7(Clone)":
            case "enemy0(Clone)":
            case "enemy1(Clone)":
                life -= 5;
                break;
            case "4(Clone)":
            case "5(Clone)":
            case "emeny3(Clone)":
            case "emeny2(Clone)":
            case "emeny7(Clone)":
            case "emeny8(Clone)":
                life -= 8;
                break;
            case "boss0(Clone)":
            case "boss1(Clone)":
            case "boss2(Clone)":
                life =0 ;
                break;
            default:
                break;
        }

        if (life <= 0)  //飞机敌机一起爆炸,游戏结束.
        {
            Explosion(this.gameObject,true,0.4f);//飞机自己爆炸

        }
        if (collision.gameObject.CompareTag("emenyBul"))
        {
            Explosion(collision.gameObject, false,0.3f);//子弹消失
        }
        else {
            Explosion(collision.gameObject, true,0.3f);//飞机爆炸
        }
        
    }
    

    public void Explosion(GameObject gameObject,bool isExplosion,float time) {
        if (isExplosion)
        {
            var explosion = Instantiate(baozha);
            explosion.transform.position = gameObject.transform.position;
            Destroy(explosion, time);
        }
        
        Destroy(gameObject.gameObject);
    }

}
