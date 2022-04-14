using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossMove : MonoBehaviour
{
    public float bossLength=0.05f; //每移动一步的步长
    public float bossTime = 0.05f; //每移动一次的时间间隔
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireAfterXSeconds());
    }

    private void Update()
    {
        if (this.transform.position.y < -10.5)
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator FireAfterXSeconds()
    {
        while (true)
        {
            this.transform.position -= new Vector3(0, bossLength, 0);
            this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,-1);
            yield return new WaitForSeconds(bossTime);
           

        }
    }
}
