using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public static GameControler instance;

    public GameObject gameOverText;
    public bool gameOver;
    public float scrollSpeed = -1.5f;
    private int score;
    public Text scoreText;


    private void Awake()
    {
        if (GameControler.instance == null)
        {
            GameControler.instance = this;
        }
        else if (GameControler.instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("GameController ha sido instanciado por segunda vez. Esto no deberia pasar");
        }
    }


   public void BirdScored()
    {
        if (gameOver) return;

        score++;
        scoreText.text = "PUNTUACIÓN: " + score;
        SoundSystem.instance.PlayCoin();
    }

    // Update is called once per frame
   

    public void BirdDie()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    private void OnDestroy()
    {
        if (GameControler.instance == this)
        {
            GameControler.instance = null;
        }
    }



}




