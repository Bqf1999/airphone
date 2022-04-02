using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//飞机发射子弹，挂载到枪口上。
public class Fire : MonoBehaviour
{
    public Rigidbody2D bull1;             //子弹类型
    public Rigidbody2D bull2;
    public GameObject left;               //左侧枪口
    public GameObject right;              //右侧枪口

    public float Bull_speed;              //子弹的运动速度

    public int score;                     //分数升级枪口

    public float fireSeparation = 0.5f;   //产生子弹的速度

    private void Start()
    {
        StartCoroutine(FireAfterXSeconds());
    }
    

    IEnumerator FireAfterXSeconds()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireSeparation);
            if (score > 100)
            {
                var newBulletle = Instantiate(bull2, left.transform);
                newBulletle.velocity = new Vector2(left.transform.position.x, Bull_speed);

                var newBulletri = Instantiate(bull2, right.transform);
                newBulletri.velocity = new Vector2(right.transform.position.x, Bull_speed);

            }
            else {
                var newBullet = Instantiate(bull1, this.transform);
                newBullet.velocity = new Vector2(this.transform.position.x,Bull_speed);
            }
            
        }
    }
}
