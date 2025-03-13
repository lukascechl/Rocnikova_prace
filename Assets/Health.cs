using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
[SerializeField] public float startHealth;

public float currentHealth { get; private set; }

private void Awake()
{
    currentHealth = startHealth;
}
public void TakeDamage(float _damage)
{
    currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startHealth);
}
private void Update()
{
    if (Input.GetKeyDown(KeyCode.E))
    {
        TakeDamage(10);
    }
}
}
