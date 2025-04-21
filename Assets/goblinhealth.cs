using UnityEngine;

public class goblinhealth : MonoBehaviour
{
    public Item smallitem;
    public Item bigitem;
    public Item hpitem;
    public Item dmgitem;
    [SerializeField] public float maxHealth = 100; // Maximum health of the goblin
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

        if (maxHealth <= 0)
        {
            Destroy(gameObject);

        int nahodneCislo = Random.Range(1, 101);
        Debug.Log("Náhodné číslo: " + nahodneCislo);

        if (nahodneCislo <= 15) 
        {
            ItemMgmt.instance.Add(dmgitem); 
        }
        else if (nahodneCislo <= 30) 
        {
            ItemMgmt.instance.Add(smallitem); 
        }
        else if (nahodneCislo <= 40) 
        {
            ItemMgmt.instance.Add(hpitem); 
        }
        else if (nahodneCislo <= 50) 
        {
            ItemMgmt.instance.Add(bigitem); 
        }

        }
        
    }  
    void Attack()
    {
        // Attack logic here
        maxHealth -= 10; // Set the maximum health of the goblin
    }
}
