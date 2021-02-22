using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private int coinCount = 0;
    [SerializeField]private TextMeshProUGUI countText;
    // Start is called before the first frame update
    void Start()
    {
        countText.text = $"x0{coinCount}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoin()
    {
        coinCount++;
        if (coinCount < 10)
        {
            countText.text = $"x0{coinCount}";
        }
        else
        {
            countText.text = $"x{coinCount}";
        }
        
    }
}
