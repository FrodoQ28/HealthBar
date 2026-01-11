public class HealButton : CustomButton
{
    protected override void OnClick() =>
        _health.Heal(_value);
}
