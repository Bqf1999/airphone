using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isHit : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("+++++++++++++++++++++++++++++++++++++++++++++++");
        if (collision.gameObject.CompareTag("bul"))  //发生碰撞子弹
        {

            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }
    }

}
