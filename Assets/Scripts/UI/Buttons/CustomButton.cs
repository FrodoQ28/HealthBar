using UnityEngine.UI;
using UnityEngine;

public class CustomButton : MonoBehaviour
{
    [SerializeField] protected Button _button;
    [SerializeField] protected Health _health;

    protected float _value = 25f;

    protected void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    protected void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    protected virtual void OnClick() { }

}
