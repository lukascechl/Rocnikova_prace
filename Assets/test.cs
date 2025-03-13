using UnityEngine;

public class player : MonoBehaviour
{
[SerializeField] private float startHealth;
private float currentHealth;

private void awake()
{
    currentHealth = startHealth;
}
public void TakeDamage(float _damage)
{
    currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startHealth);
    if (currentHealth == 0)
    {
        //smrt
    }
}
}
