using UnityEngine;
using UnityEngine.Events;

public class GameManager : Singleton<GameManager>
{
    public UnityEvent<int> OnMoneyChanged;

    private int _money;

    public int Money
    {
        get => _money;
        set
        {
            _money += value; // หรือ _money += value; ถ้าต้องการเพิ่มเงิน
            OnMoneyChanged?.Invoke(_money);
        }
    }
}
