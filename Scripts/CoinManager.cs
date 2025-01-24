using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public Text coinText;

    void Update()
    {
        coinText.text = "Coins: " + coinCount.ToString();
    }
}
