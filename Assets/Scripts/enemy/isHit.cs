using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isHit : MonoBehaviour
{
    public GameObject baozha;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isExist = true;
        
        if (collision.gameObject.CompareTag("bul"))  //发生碰撞子弹
        {
            string name = this.gameObject.name;

            switch (name)
            { 
                case "enemy0(Clone)":
                    airLife.score += 3;
                    UI.array.Add(0);
                    break;
                case "enemy1(Clone)":
                    airLife.score += 3;
                    UI.array.Add(1);
                    break;
                case "emeny3(Clone)":
                    airLife.score += 5;
                    UI.array.Add(2);
                    break;
                case "emeny2(Clone)":
                    airLife.score += 5;
                    UI.array.Add(3);
                    break;
                case "emeny7(Clone)":
                    airLife.score += 8;
                    UI.array.Add(4);
                    break;
                case "emeny8(Clone)":
                    airLife.score += 8;
                    UI.array.Add(5);
                    break;
                case "boss0(Clone)":
                    this.gameObject.GetComponent<emenyLife>().bossLife -= 1;
                    if (this.gameObject.GetComponent<emenyLife>().bossLife > 0)
                    {
                        isExist = false;
                        Destroy(collision.gameObject);
                    }
                    UI.array.Add(6);
                    break;
                case "boss1(Clone)":
                    this.gameObject.GetComponent<emenyLife>().bossLife -= 1;
                    if (this.gameObject.GetComponent<emenyLife>().bossLife > 0)
                    {
                        isExist = false;
                        Destroy(collision.gameObject);
                    }
                    UI.array.Add(7);
                    break;
                case "boss2(Clone)":
                    this.gameObject.GetComponent<emenyLife>().bossLife -= 1;
                    if (this.gameObject.GetComponent<emenyLife>().bossLife > 0)
                    {
                        isExist = false;
                        Destroy(collision.gameObject);
                    }
                    UI.array.Add(8);
                    break;
                default:
                    break;
            }
            if (isExist)
            {
                var newBullet = Instantiate(baozha);
                newBullet.transform.position = this.transform.position;
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                Destroy(newBullet, 0.2f);
                if (name == "boss0(Clone)") {
                    airLife.score += 10;
                } else if (name == "boss1(Clone)") {
                    airLife.score += 15;
                } else if (name == "boss2(Clone)") {
                    airLife.score += 20;
                }
            }

            
        }
        
    }

}
