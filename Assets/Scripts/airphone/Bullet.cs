using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//子弹的移动，挂载到子弹上

public class Bullet : MonoBehaviour
{
    public float bullet_speed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2f);
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    transform.position += new Vector3(0, bullet_speed, 0);
    //}
}
