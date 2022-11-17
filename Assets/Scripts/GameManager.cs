using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;

public class GameManager : MonoBehaviour
{
    public GameObject RestartCanvas;

    public Text lifeText;
    public Text timeText;
    public Text levelText;

    int life = 3;
    int level = 1;

    float startTime = 0f;
    float endTime = 1.5f;
    int speedTime = 7;
    float endTimer = 0f;
    float speedTimer = 0f;

    bool endGame = false;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1f;
        life = 3;
        startTime = Time.time;
        RestartCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update () {

        if(endTimer > endTime){
            Time.timeScale = 0;
            RestartCanvas.SetActive(true);
        }

        if(!endGame){
            lifeText.text = "Life: " + life;
            timeText.text = "Time: " + (int)(Time.time - startTime);
            levelText.text = "Level: " + level;

            speedTimer += Time.deltaTime;
            if((int)speedTimer >= speedTime){
                speedTimer = 0;
                level++;
                GameObject.Find("TurtleSpawner").GetComponent<TurtleSpawner>().increaseSpeed();
            }
        }

        if(life <= 0){
            endGame = true;
            endTimer += Time.deltaTime;
        }
    }

    public void minusLife(){
        life--;
    }
}
