using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss1Fire : MonoBehaviour
{

    public GameObject one;
    public GameObject two;
    public GameObject second;
    public GameObject bullet;

    public float speedBossFire;

    public float existBullet = 8f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireAfterXSeconds());
    }
    
    IEnumerator FireAfterXSeconds() {
        int x = 3;

        while (true)
        {

            yield return new WaitForSeconds(speedBossFire);
            /*
            var bull1 = Instantiate(bull1, one.transform);

            */
            this.transform.Rotate(0, 0, x);
            
            
            var bull1 = Instantiate(bullet);
            bull1.transform.position = one.transform.position;
            bull1.GetComponent<bulletMove>().movingDirection = one.transform.up;
            Destroy(bull1,existBullet);



            var bull2 = Instantiate(bullet);
            bull2.transform.position = two.transform.position;
            bull2.GetComponent<bulletMove>().movingDirection = two.transform.up;
            Destroy(bull2, existBullet);

            var bull3 = Instantiate(bullet);
            bull3.transform.position = second.transform.position;
            bull3.GetComponent<bulletMove>().movingDirection = second.transform.up;
            Destroy(bull2, existBullet);


        }
    }
   
}
