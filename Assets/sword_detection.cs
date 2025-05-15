using UnityEngine;
using System.Collections.Generic;

public class sword_detection : MonoBehaviour
{
 public List<Collider2D> sword_detected = new List<Collider2D>();
    Collider2D col;
    private void Awake()
    {
        col = GetComponent<Collider2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sword_detected.Add(collision);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sword_detected.Remove(collision);
    }
}
