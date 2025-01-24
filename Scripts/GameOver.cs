using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text CoinsText;

    public void EndGame(int score)
    {
        gameObject.SetActive(true);
        CoinsText.text = score.ToString() + " COINS";
        Time.timeScale = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
