using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI _Score;
    [HideInInspector] public int _scoreCoins;
    private void Start()
    {
        _scoreCoins = 0;
        _Score.text = "Score:" + _scoreCoins;
    }

    private void OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.tag == "Coin")
        {
            _scoreCoins++;
            Destroy(coin.gameObject);
            _Score.text = "Score:" + _scoreCoins.ToString();
        }
    }
}
