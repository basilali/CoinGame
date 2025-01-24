using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameOver gameOver;
    public CoinManager cm;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Debug.Log("Game Over");
            gameOver.EndGame(cm.coinCount);
        }
    }
}
