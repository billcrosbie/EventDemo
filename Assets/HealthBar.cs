using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    void OnEnable()
    {
        Player.OnHealthChanged += UpdateHealthBar;
    }

    void OnDisable()
    {
        Player.OnHealthChanged -= UpdateHealthBar;
    }

    void UpdateHealthBar(int newHealth)
    {
        // Update the health bar UI
        Debug.Log("Health: " + newHealth);
        GetComponent<Slider>().value = newHealth;
    }
}

