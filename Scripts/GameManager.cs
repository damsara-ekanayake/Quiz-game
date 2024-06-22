using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    EndScreen endscreen;

    void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
        endscreen = FindObjectOfType<EndScreen>();
    }

    // Start is called before the first frame update
    void Start()
    {
        quiz.gameObject.SetActive(true);
        endscreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameEnded();
    }

    void GameEnded()
    {
        if(quiz.isComplete)
        {
          quiz.gameObject.SetActive(false);
          endscreen.gameObject.SetActive(true);
          endscreen.ShowFinalScore();
        }

    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
