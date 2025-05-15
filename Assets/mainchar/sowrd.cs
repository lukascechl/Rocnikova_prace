using UnityEngine;
using System.Collections.Generic;

public class sowrd : MonoBehaviour
{
    public playerattack playerAttack;
    public GameObject sword; // Reference to the sword GameObject
    [SerializeField] private Animator _animator;
    public sword_detection swordDetection;
    
    
    void swing()
    {
        sword.transform.localPosition = Vector3.zero; // Vrátíme meč na základní pozici
        sword.SetActive(false);
        _animator.SetBool("swing", false);

    }
    void damage()
    {
        if (swordDetection.sword_detected.Count == 1)
        {
            swordDetection.sword_detected[0].GetComponent<goblinhealth>().Attack(playerAttack.hitdamage);
        }
        else if (swordDetection.sword_detected.Count == 2)
        {
            swordDetection.sword_detected[1].GetComponent<goblinhealth>().Attack(playerAttack.hitdamage);
        }
        else if (swordDetection.sword_detected.Count == 3)
        {
            swordDetection.sword_detected[2].GetComponent<goblinhealth>().Attack(playerAttack.hitdamage);
        }

    }
    void Start()
{
    if (sword == null)
    {
        sword = transform.Find("Sword").gameObject;
    }
}

}
