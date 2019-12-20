using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScreenLoader : MonoBehaviour
{

    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guess;
    int nextGuessNo=500;


    public void nextGuess() {
        
        nextGuessNo = Random.Range(min, max);
        Debug.Log(nextGuessNo + "::"+ min +" ::" +max);
        guess.text = nextGuessNo.ToString();
    
    }

    public void isHigher() {
        Debug.Log("Calling is Higher"+nextGuessNo);
        min = nextGuessNo + 1;
        nextGuess();
    }
    public void isLower()
    {
        Debug.Log("Calling is Lower" + nextGuessNo);
        max = nextGuessNo - 1;
        nextGuess();
    }

    public void loadNextScene() {

        int index = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(SceneManager.GetActiveScene().ToString());
        SceneManager.LoadScene(index+1);
    
    }

    public void loadStartScene() {

        SceneManager.LoadScene(0);
    
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Start() { 
    
        
    }

}
