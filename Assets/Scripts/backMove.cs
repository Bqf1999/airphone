using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backMove : MonoBehaviour
{
    public GameObject Object;

    void Start()
    {
        StartCoroutine(FireAfterXSeconds());
    }


    IEnumerator FireAfterXSeconds()
    {
        while (true)
        {
            this.transform.position -= new Vector3(0, 0.05f, 0);
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -1);
            yield return new WaitForSeconds(0.01f);


        }
    }
}
