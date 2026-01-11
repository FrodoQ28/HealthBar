public class DamageButton : CustomButton
{
    protected override void OnClick() =>
        _health.TakeDamage(_value);
}
