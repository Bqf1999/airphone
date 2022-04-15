using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BornEmeny : MonoBehaviour
{
    public GameObject emeny1;
    public GameObject emeny2;
    public GameObject emeny3;
    public GameObject emeny4;
    public GameObject boss;

    public GameObject air;

    public float airControlSpeed=1; //1---0.5--0.3

    public float bulControlSpeed=1f;


    public int[] born = new int[]   { 0,0,1,0,1,2,1,3,0,3,1,2,3,1,4}; //生产列表
    public float[] time = new float[] { 3, 2, 3, 2, 3, 2, 3, 2, 2, 2, 2, 1, 1, 3, 10 };


    

    private void OnEnable()   //初始化
    {
        StartCoroutine("Emeny");
        var newBullet = Instantiate(air);
        newBullet.transform.position = new Vector3(0, 0, -1);
        airLife.life = 100;
        airLife.score = 0;
    }

    public void Update()
    {
        if (airLife.life <= 0 && airLife.birth == 0)   //游戏结束，停止协程
        {
            StopCoroutine("Emeny");
        }
    }

   

    IEnumerator Emeny()
    {
        int x = 0;

        while (true)
        {
           
            GameObject newBullet;
            
            float xx = Random.Range(-4.6f,4.6f);
            
            if (born[x] == 0)
            {
                newBullet = Instantiate(emeny1);
                newBullet.transform.position = new Vector3(xx, 9.5f, 0);
                newBullet.GetComponent<bossMove>().bossTime = airControlSpeed*0.05f;

               
            }
            else if (born[x] == 1)
            {
                 newBullet = Instantiate(emeny2);
                newBullet.transform.position = new Vector3(xx, 9.5f, 0);
                newBullet.GetComponent<bossMove>().bossTime = airControlSpeed * 0.05f;

            }
            else if(born[x] == 2)
            {
                newBullet = Instantiate(emeny3);
                newBullet.transform.position = new Vector3(xx, 9.5f, 0);
                newBullet.GetComponent<bossMove>().bossTime = airControlSpeed * 0.05f;
                
            }
            else if (born[x] == 3)
            {
                newBullet = Instantiate(emeny4);
                newBullet.transform.position = new Vector3(xx, 9.5f, 0);
                newBullet.GetComponent<bossMove>().bossTime = airControlSpeed * 0.05f;

            }
            else if(born[x]==4)
            {
                newBullet = Instantiate(boss);
                newBullet.transform.position = new Vector3(0, 9.5f, 0);
                                                          
            }
             yield return new WaitForSeconds(time[x]);
            
            x++;
            if (x == 15)
            {
                x = 0;
            }
            
        }

    }
}
