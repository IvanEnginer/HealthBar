using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private float _changeSpeed = 1.0f;

    private void OnEnable()
    {
        _player.ChangingHealth += OnChangingHealth;
    }

    private void OnDisable()
    {
        _player.ChangingHealth -= OnChangingHealth;
    }

    private void OnChangingHealth()
    {
        float target = _player.Health / _player.MaxHealth;
        _slider.DOValue(target, _changeSpeed).SetEase(Ease.Linear);
    }
}
