using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isHit : MonoBehaviour
{
    public GameObject baozha;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("+++++++++++++++++++++++++++++++++++++++++++++++");
        if (collision.gameObject.CompareTag("bul"))  //发生碰撞子弹
        {
            var newBullet = Instantiate(baozha);
            newBullet.transform.position = this.transform.position;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Destroy(newBullet, 0.1f);
            

        }
    }

}
