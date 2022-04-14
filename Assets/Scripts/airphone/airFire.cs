using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//飞机发射子弹，挂载到枪口上。
public class airFire : MonoBehaviour
{
    public GameObject bull1;             //子弹类型
    public GameObject bull2;
    public GameObject left;               //左侧枪口
    public GameObject right;              //右侧枪口

    

                   

    
    public float BullProduceTime = 0.01f;   //产生子弹的速度

    private void Start()
    {
        StartCoroutine(FireAfterXSeconds());
    }
    

    IEnumerator FireAfterXSeconds()
    {
        while (true)
        {
            yield return new WaitForSeconds(BullProduceTime);
            if (airLife.score > 100)
            {
                var newBulletle = Instantiate(bull2);
                //newBulletle.velocity = new Vector2(left.transform.position.x, Bull_speed);
                newBulletle.transform.position = left.transform.position;
               
                var newBulletri = Instantiate(bull2);
                //newBulletri.velocity = new Vector2(right.transform.position.x, Bull_speed);
                newBulletri.transform.position = right.transform.position;
                
            }
            else {
                var newBullet = Instantiate(bull1);
                //newBullet.velocity = new Vector2(0,Bull_speed);
                newBullet.transform.position = this.transform.position;
                
            }
            
        }
    }
}
