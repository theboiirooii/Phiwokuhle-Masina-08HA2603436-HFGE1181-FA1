using UnityEngine;
using UnityEngine.SceneManagement;

public class WinOnCollission : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Player"))
        {
            Debug.Log("LEVEL FINISHED - YOU WIN!");
            Time.timeScale = 0f;
        }
    }
}