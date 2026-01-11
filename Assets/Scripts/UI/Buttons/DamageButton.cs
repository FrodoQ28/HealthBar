using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Health _health;

    private float _damage = 25f;

    private void OnEnable()
    {
        _button.onClick.AddListener(TakeDamage);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(TakeDamage);
    }

    private void TakeDamage() =>
        _health.TakeDamage(_damage);
}
