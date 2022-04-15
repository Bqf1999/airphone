using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    public Text score;
    public Slider life;
    public Text lifeValue;
    public Text birth;

    public GameObject canvas;
    public GameObject stage;

    public GameObject baozha;

    public static bool gameOver = false;


    public static ArrayList array = new ArrayList();

    public Sprite []sprite=new Sprite[8];
    
    public Image []image=new Image[5];

    public Text[] text = new Text[5];
    public Text title;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "0";
        life.value = 1f;
        lifeValue.text = "100";
        birth.text = "X " + airLife.birth;
    }


    // Update is called once per frame
    void Update()
    {
        score.text = airLife.score+"";
        
        life.value = (float)airLife.life/100;
        if (airLife.life < 0)
        {
            lifeValue.text = "" + 0;
        }
        else {

            lifeValue.text = "" + airLife.life;
        }

        birth.text = "X " + airLife.birth;

        if (gameOver)
        {
            stage.SetActive(false);  // 游戏结束，页面跳转。
            canvas.SetActive(true);
            print("游戏结束");
        }

    }

    public void GameOver() {

        int[] im = new int[9]{0,0,0,0,0,0,0,0,0};
        
        foreach (int i in array) {
            im[i] += 1;
        }

        int tag = 0;

        for (int i = 0; i < 9; i++)
        {
            if (im[i] != 0)
            {
                image[tag].sprite = sprite[i];



                tag++;
            }
        }
    }


}
