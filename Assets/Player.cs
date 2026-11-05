using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void HealthChanged(int newHealth);
    public static event HealthChanged OnHealthChanged;

    private int health = 100;

    public void OnMouseDown()
    {
        Debug.Log("Mouse Down!!!");
        TakeDamage(5);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        OnHealthChanged?.Invoke(health);
    }
}
