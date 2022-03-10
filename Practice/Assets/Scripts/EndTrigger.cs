
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager endfn;
    void OnTriggerEnter() {
       endfn.CompleteLevel();
   }
}
