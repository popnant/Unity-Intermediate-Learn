using UnityEngine;
using PrimeTween;
using NaughtyAttributes;

public class Coin : MonoBehaviour, ICollectable 
{
    [SerializeField] private int price = 5;

    void PrintCurrentMoney(int currentMoney)
    {
        Debug.Log($"Current money is {currentMoney}");
    }

    private void OnEnable()
    {
        GameManager.Instance.OnMoneyChanged.AddListener(PrintCurrentMoney);

        Tween.PositionY(transform, transform.position.y + 0.25f, 1f, cycles: 9999, cycleMode: CycleMode.Yoyo);
    }

    private void OnDisable()
    {
        GameManager.Instance.OnMoneyChanged.RemoveListener(PrintCurrentMoney);
    }

    public void Collect()
    {
        GameManager.Instance.Money += price;
        Destroy(gameObject);
    }

    [Button("Rotate to Quaternion.identity")]
    private void Quaternion_Identity()
    {
        transform.rotation = Quaternion.identity;
    }
}
