using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    public Text score;
    public Slider life;
    public Text lifeValue;

    public GameObject canvas;
    public GameObject stage;

    public GameObject baozha;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "0";
        life.value = 1f;
        lifeValue.text = "100";
    }

    // Update is called once per frame
    void Update()
    {
        score.text = airLife.score+"";
        lifeValue.text = "" + airLife.life;
        life.value = (float)airLife.life/100;
        if (airLife.life <= 0)
        {
            StartCoroutine(Over());
        }
    }

    IEnumerator Over() {
      GameObject[] emenyBul= GameObject.FindGameObjectsWithTag("emenyBul");
      GameObject[] enemy = GameObject.FindGameObjectsWithTag("enemy");
        foreach (GameObject g in emenyBul)
        {
            Explosion(g, true,0.4f);
            print("1");
        }
        foreach (GameObject g in enemy) {

            Explosion(g, true, 0.3f);
            print("2");
        }
        yield return new WaitForSeconds(5);
        stage.active = false;
        canvas.active = true;
    }
    public void Explosion(GameObject gameObject, bool isExplosion,float time)
    {
        if (isExplosion)
        {
            var explosion = Instantiate(baozha);
            explosion.transform.position = gameObject.transform.position;
            Destroy(explosion, time);
        }

        Destroy(gameObject.gameObject);
    }

}
