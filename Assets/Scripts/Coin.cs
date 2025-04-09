using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int price = 5;
    void PrintCurrentMoney(int currentMoney)
    {
            Debug.Log($"Current money is {currentMoney}");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnEnable()
    {
        GameManager.Instance.OnMoneyChanged.AddListener(PrintCurrentMoney);
    }
    private void OnDisable()
    {
        GameManager.Instance.OnMoneyChanged.RemoveListener(PrintCurrentMoney);
    }

    public void Collect()
    {
        GameManager.Instance.Money = price;
        Destroy(gameObject);
    }

}
