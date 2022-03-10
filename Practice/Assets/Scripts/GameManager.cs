using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float gameRestartDelay = 2f;

    public GameObject gameCompleteUI; 
    public void EndGame(){

        if(gameEnded == false){
            gameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart",gameRestartDelay);
        }

    
    }

    public void CompleteLevel(){
        gameCompleteUI.SetActive(true);
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }  

    public void CompleteGame(){
        Debug.Log("Game won");
    }
}
