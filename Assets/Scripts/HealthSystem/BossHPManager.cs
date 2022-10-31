using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossHPManager : BasicHealthSystem
{
    [SerializeField] private BasicHealthSystem _bossHP;
    [SerializeField] private Slider _slider;

    private void Awake()
    {
        SetMaxValue();
    }

    private void Update()
    {
        SetCurrentValue();
    }

    private void SetMaxValue() {
        _slider.maxValue = _bossHP.MaxHealth; 
    }

    private void SetCurrentValue() {
        _slider.value = _bossHP.Health;

        if (_bossHP.Health <= 0) {
            EndGame();
        }
    }

    private void EndGame() {
        SceneManager.LoadScene(0);
    }
}
