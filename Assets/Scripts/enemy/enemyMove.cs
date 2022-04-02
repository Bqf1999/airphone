using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//敌机移动，挂载到敌机上
public class enemyMove : MonoBehaviour
{

    public float direction;
    public float speed=2.0f;
    Rigidbody2D rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        int stat = Random.Range(0, 2);
        if (stat == 0)   //左
        {
            direction = 2;
            
        } else if (stat==1) //右
        {
            direction = -2;
        }
        else {     //垂直

            direction = 0;
        }
        Debug.Log(direction);
        int a=Random.Range(0,3);
        rigidbody.AddForce(new Vector3(a*direction * speed , -(speed), 0)*30);
        Debug.Log(this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
       
        //float h = Input.GetAxis("Vertical");
        //transform.position+=new Vector3( direction*speed * Time.deltaTime, -(speed * Time.deltaTime), 0);
           
    }


}
