using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public int speed = 10;
    public float xMax, xMin, yMax, yMin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //前进
        if (Input.GetKey(KeyCode.W))
        {
            
            float h = Input.GetAxis("Vertical");
            this.transform.position += new Vector3(h*speed*Time.deltaTime, h *speed * Time.deltaTime, 0);
            this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, xMin, xMax), Mathf.Clamp(this.transform.position.y, yMin, yMax), -1);

        }
        //左移
        if (Input.GetKey(KeyCode.A))
        {
            float w = Input.GetAxis("Horizontal");
            this.transform.position += new Vector3(w * speed * Time.deltaTime, 0, 0);
            this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, xMin, xMax), Mathf.Clamp(this.transform.position.y, yMin, yMax), -1);

        }
        //后退
        if (Input.GetKey(KeyCode.S))
        {
            float h = Input.GetAxis("Vertical");
            this.transform.position += new Vector3(0, h * speed * Time.deltaTime, 0);
            this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, xMin, xMax), Mathf.Clamp(this.transform.position.y, yMin, yMax), -1);

        }
        //右移
        if (Input.GetKey(KeyCode.D))
        {
            float w = Input.GetAxis("Horizontal");
            this.transform.position += new Vector3(w * speed * Time.deltaTime, 0, 0);
            this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, xMin, xMax), Mathf.Clamp(this.transform.position.y, yMin, yMax), -1);

        }

    }
}
