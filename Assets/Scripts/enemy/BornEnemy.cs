using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//生产敌机的控制类，挂载到指定位置。
[System.Serializable]
public class BornEnemy : MonoBehaviour
{
    

    public float emenySeparation ;  //生产敌机间隔

    public GameObject obj1;
    public GameObject obj2;
    private int num = 1;

   

    private void Start()
    {
        StartCoroutine(FireAfterXSeconds());
    }

    

    IEnumerator FireAfterXSeconds()
    {
        int x = 0;
        while (true)
        {
            x = num % 5;
            yield return new WaitForSeconds(emenySeparation);
            
            if (x == 0)
            {
                var newBullet = Instantiate(obj2, this.transform);
                
            }
            else {
                var newBullet = Instantiate(obj1, this.transform);
            }
            num++;
            //newBullet.GetComponent<enemyMove>().speed = newBullet.GetComponent<enemyMove>().speed*boTime[n].speed;

        }

    }
}
