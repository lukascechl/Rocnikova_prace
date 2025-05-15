using UnityEngine;

public class goblinhealth : MonoBehaviour
{
    public Item smallitem;
     public float smallitemchance2;
    public Item bigitem;
    public float bigitemchance4;
    public Item hpitem;
    public float hpitemchance3;
    public Item dmgitem;
    public float dmgitemchance1;
    
    [SerializeField] public float maxHealth = 100; // Maximum health of the goblin
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Attack(float damage)
    {
        // Attack logic here
        maxHealth -= damage; // Set the maximum health of the goblin
        if (maxHealth <= 0)
        {
            Destroy(gameObject);
            int nahodneCislo = Random.Range(1, 101);
            Debug.Log("Náhodné číslo: " + nahodneCislo);

            if (nahodneCislo <= dmgitemchance1) 
            {
                ItemMgmt.instance.Add(dmgitem); 
            }
            else if (nahodneCislo <= smallitemchance2) 
            {
                ItemMgmt.instance.Add(smallitem); 
            }
            else if (nahodneCislo <= hpitemchance3) 
            {
                ItemMgmt.instance.Add(hpitem); 
            }
            else if (nahodneCislo <= bigitemchance4) 
            {
                ItemMgmt.instance.Add(bigitem); 
            }
        }
    }
}
