using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
[SerializeField] public float startHealth;
public float maxHealth { get; private set; }
public float currentHealth { get; private set; }

private void Awake()
{
    maxHealth = startHealth;
    currentHealth = maxHealth;
}
public void TakeDamage(float _damage)
{
    currentHealth = Mathf.Clamp(currentHealth - _damage, 0, maxHealth);
}
public void Heal(float _healAmount)
{
    currentHealth = Mathf.Clamp(currentHealth + _healAmount, 0, maxHealth);
}
public void hpupgrade(float _hpupgrade)
{
    maxHealth += _hpupgrade;
    Debug.Log("Nový max health: " + startHealth);
}

private void Update()
{
    if (Input.GetKeyDown(KeyCode.E))
    {
        TakeDamage(10);
    }
}
}
