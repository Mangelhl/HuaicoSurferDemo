using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;

    private int score = 0;
    private Text scoreText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>(); // Aseg�rate de que hay un objeto de texto llamado "ScoreText" en la escena del men�
        scoreText.text = "Civiles salvados: " + score.ToString();
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Civiles salvados: " + score.ToString();
    }

    public void EndGame()
    {
        PlayerPrefs.SetInt("SavedCivilians", score); // Guarda la puntuaci�n en las preferencias del jugador

        SceneManager.LoadScene("Menu"); // Carga la escena del men�
    }

    public static ScoreManager GetInstance()
    {
        return instance;
    }
}
