using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] private int LifeCount = 3;

    private void Awake()
    {
        int numberOfGameSession = FindObjectsOfType<GameSession>().Length;
        if(numberOfGameSession > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ProcessDeath()

    {
        if (LifeCount > 1)
        {
            TakeLife();
        }
        else
        {
            ResetGameSession();
        }
    }

    private void ResetGameSession()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(0);
    }

    private void TakeLife()
    {
        LifeCount--;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
