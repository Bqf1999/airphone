using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//子弹的移动，挂载到子弹上

public class Bullet : MonoBehaviour
{
    public float bullet_speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);
        
    }

    //Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.up * bullet_speed*Time.deltaTime);

    }    
}
