using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected Rigidbody _rigibody;
    [SerializeField] protected Animator _animator;

    protected float _speed;

    protected virtual void Movement()
    {
        
    }
}
