using UnityEngine.SceneManagement;
using UnityEngine;

public class startGame : MonoBehaviour
{
   public void StartGame(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
