using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI GameOverText;
    public FixedBots f;
    public RubyController1 player;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (f.FixedBotsAmount == f.TotalBots)
        {
            GameOverText.text = "You win! Game created by Group 26.";
        }
        else if (player.currentHealth == 0)
        {
            GameOverText.text = "You lost! Press R to restart.";

            player.speed = 0.0f;
        }
            if(Input.GetKeyDown(KeyCode.R) && player.currentHealth == 0)
        {
            Restart();
        }   
    }

    void Restart()
    {
        var currentScene = SceneManager.GetActiveScene();
        var sceneName = currentScene.name;
        SceneManager.LoadScene(sceneName);
    }
}