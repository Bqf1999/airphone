using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emenyFire : MonoBehaviour
{

    public GameObject gm;
    public GameObject bul;
    public float speed_Fire; //发射子弹间隔
    public float existBullet=4f; //子弹存活时间,射程
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireAfterXSeconds());
    }
    IEnumerator FireAfterXSeconds()
    {
        
        while (true)
        {
            
            var newBulletle = Instantiate(bul);
            Destroy(newBulletle,existBullet);
            //newBulletle.transform.Rotate(0, 0, 180);
            newBulletle.transform.position = gm.transform.position;
            newBulletle.GetComponent<bulletMove>().movingDirection = new Vector3(0, -1, 0);
            
            yield return new WaitForSeconds(speed_Fire);

        }
    }

}
