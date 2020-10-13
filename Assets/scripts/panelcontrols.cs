using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class panelcontrols : MonoBehaviour
{

    public GameObject restartpanel,gameoverpanel;

    public TextMeshProUGUI screenscore, gameovertext,bestscoretext;

    public int score,scorecheck,bestscore;
    void Start()
    {
        restartpanel.SetActive(true);
        gameoverpanel.SetActive(false);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (score>scorecheck)
        {
            PlayerPrefs.SetInt("bestscore", score);
            screenscore.text =(int)score+"";
        }

    }

    public void gameover()
    {
        bestscore = PlayerPrefs.GetInt("bestscore");
        bestscoretext.text = "Best Score =" + (int)bestscore;
        gameovertext.text = "Score :" + (int)score;
        gameoverpanel.SetActive(true);
        restartpanel.SetActive(false);
       
    }

    public void restarter()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); Time.timeScale = 1;
    }
}
