using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossTwoFire : MonoBehaviour
{
    public GameObject bull;

    public GameObject le;
    public GameObject ri;

    public float existBullet; //子弹的生存时间放在生产车间

    public float speed_Fire;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireAfterXSeconds());
    }

    IEnumerator FireAfterXSeconds()
    {
        while (true)
        {

            var bulle = Instantiate(bull);
            var bulri = Instantiate(bull);

            Destroy(bulle, existBullet);
            Destroy(bulri, existBullet);

            //newBulletle.transform.Rotate(0, 0, 180);
            bulle.transform.position = le.transform.position;
            bulle.GetComponent<bulletMove>().movingDirection = new Vector3(0,-1,0);

            bulri.transform.position = ri.transform.position;
            bulri.GetComponent<bulletMove>().movingDirection = new Vector3(0, -1, 0);

            yield return new WaitForSeconds(speed_Fire);

        }
    }
}
