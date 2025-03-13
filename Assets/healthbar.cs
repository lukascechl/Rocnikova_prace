using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health player;
    [SerializeField] private Image redBar;
    [SerializeField] private TMP_Text HpText;  

    public gameoverscr gameoverscr;


public void Gameover(){
    gameoverscr.gameObject.SetActive(true);
}
public void Start()
{
}

public void Update()
{
    redBar.fillAmount = player.currentHealth/100;
    HpText.text = player.currentHealth.ToString()+"/"+ player.startHealth.ToString();
if (player.currentHealth <= 0)
{
    Gameover();
}
}
}