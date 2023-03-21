using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour
{
   public void LoadFirstLEvel()
   {
        SceneManager.LoadScene(1);
   }

    public void GameExit()
    {
        Application.Quit();
    }

    public void GameRules()
    {
        SceneManager.LoadScene(4);
    }
}
