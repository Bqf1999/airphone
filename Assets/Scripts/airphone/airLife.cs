using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class airLife : MonoBehaviour
{
    public  static float  life=100; //飞机生命值

    public  static int score = 0;  //得分

    public static int birth=0;      //几条命

    private bool noHarmTime = false;
    

    public GameObject baozha; //飞机爆炸播放的动画。


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("bul"))
        {
            return;
        }

        if (noHarmTime)     //判断无敌状态
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
                life -=30 ;
                break;
            default:
                break;
        }


        if (life <= 0)       //血条无
        {
            
            if (birth == 0)  //游戏结束
            {
                airLife.life = 0;
                Explosion(this.gameObject, true, 1f);//飞机自己爆炸
                
                StartCoroutine(Over());

                


            }
            else {           //减去一条命，血条+100
                birth -= 1;
                life += 100;
                StartCoroutine("noHarm");
            }
        }
        if (collision.gameObject.CompareTag("emenyBul"))
        {
            Explosion(collision.gameObject, false,1f);//子弹消失
        }
        else {
            Explosion(collision.gameObject, true,1f);//飞机爆炸
        }
        
    }

    IEnumerator Over()
    {
        FindGameObject();
        
        for (int i = 0; i < 4; i++)
        {
            float x = Random.Range(-4f, 4f);
            for (int j = 0; j < 4; j++)
            {
                float y = Random.Range(-9f, 9f);
                GameObject gameObject = new GameObject();
                gameObject.transform.position = new Vector3(x, y, -1);
                Explosion(gameObject, true, 1f);
               
            }
        }
        
            yield return new WaitForSeconds(3f);
          
    }


    IEnumerator noHarm()    //通过一个变量来控制无敌时间，
    {
        noHarmTime = true;
        yield return new WaitForSeconds(10f);
        noHarmTime = false;
    }

    public  void FindGameObject()
    {

        GameObject[] emenyBul = GameObject.FindGameObjectsWithTag("emenyBul");
        GameObject[] enemy = GameObject.FindGameObjectsWithTag("enemy");
        GameObject[] bul = GameObject.FindGameObjectsWithTag("bul");
        foreach (GameObject b in bul)
        {
            Explosion(b, true, 0.2f);
        }
        foreach (GameObject g in emenyBul)
        {
            Explosion(g, true, 0.2f);

        }
        foreach (GameObject g in enemy)
        {

            Explosion(g, true, 0.2f);

        }
    }

    public  void Explosion(GameObject gameObject,bool isExplosion,float time) {  //爆炸函数
        if (isExplosion)
        {
            var explosion = Instantiate(baozha);
            explosion.transform.position = gameObject.transform.position;
            Destroy(explosion, time);
        }
        
        Destroy(gameObject.gameObject);
    }

}
