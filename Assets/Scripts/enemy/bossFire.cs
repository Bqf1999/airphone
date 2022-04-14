using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossFire : MonoBehaviour
{

    public GameObject bul;

    public GameObject gm1;
    public GameObject gm2;
    public GameObject gm3;
    public GameObject gm4;
    public GameObject gm5;
    public GameObject gm6;
    public GameObject gm7;
    public GameObject gm8;

    public float existBullet = 8f;

    public float speed_Fire = 4f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireAfterXSeconds());
    }
    IEnumerator FireAfterXSeconds()
    {
        while (true)
        {
            /*
            var bull1 = Instantiate(bull1, one.transform);

            */
            var bull1 = Instantiate(bul);
            bull1.transform.Rotate(0,0,-90);
            bull1.transform.position = gm1.transform.position;
            bull1.GetComponent<bulletMove>().movingDirection = gm1.transform.up;
            Destroy(bull1, existBullet);

            var bull2 = Instantiate(bul);
            bull2.transform.position = gm2.transform.position;
            bull2.GetComponent<bulletMove>().movingDirection = gm2.transform.up;
            Destroy(bull2, existBullet);

            var bull3 = Instantiate(bul);
            bull3.transform.Rotate(0, 0, -180);
            bull3.transform.position = gm3.transform.position;
            bull3.GetComponent<bulletMove>().movingDirection = gm3.transform.up;
            Destroy(bull3, existBullet);

            var bull4 = Instantiate(bul);
            bull4.transform.Rotate(0,0,-45);
            bull4.transform.position = gm4.transform.position;
            bull4.GetComponent<bulletMove>().movingDirection = gm4.transform.up;
            Destroy(bull4, existBullet);

            var bull5 = Instantiate(bul);
            bull5.transform.Rotate(0, 0, 45);
            bull5.transform.position = gm5.transform.position;
            bull5.GetComponent<bulletMove>().movingDirection = gm5.transform.up;
            Destroy(bull5, existBullet);

            var bull6 = Instantiate(bul);
            bull6.transform.Rotate(0, 0, -135);
            bull6.transform.position = gm6.transform.position;
            bull6.GetComponent<bulletMove>().movingDirection = gm6.transform.up;
            Destroy(bull6, existBullet);

            var bull7 = Instantiate(bul);
            bull7.transform.Rotate(0, 0, 135);
            bull7.transform.position = gm7.transform.position;
            bull7.GetComponent<bulletMove>().movingDirection = gm7.transform.up;
            Destroy(bull7, existBullet);

            var bull8 = Instantiate(bul);
            bull8.transform.Rotate(0, 0, 90);
            bull8.transform.position = gm8.transform.position;
            bull8.GetComponent<bulletMove>().movingDirection = gm8.transform.up;
            Destroy(bull8, existBullet);

            yield return new WaitForSeconds(speed_Fire);

        }
    }

}
