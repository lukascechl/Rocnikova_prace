using System.Collections.Generic;
using UnityEngine;

public class detection : MonoBehaviour
{
    public List<Collider2D> detected = new List<Collider2D>();
    Collider2D col;
    private void Awake()
    {
        col = GetComponent<Collider2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        detected.Add(collision);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        detected.Remove(collision);
    }
}
