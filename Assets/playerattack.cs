using UnityEngine;

using TMPro;

public class playerattack : MonoBehaviour
{
    public GameObject sword;           // Odkaz na GameObject meče
    public float moveDistance = 1f;    // Vzdálenost, o kterou se meč posune
    private Camera mainCamera;
    [SerializeField] private Animator _animator;
    [SerializeField] private TMP_Text dmgText; 
    public float hitdamage = 10;
    

    void Start()
    {
        mainCamera = Camera.main;
        if (sword != null)
        {
            sword.SetActive(false); // Na začátku meč vypneme
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && sword != null)
        {
            // Aktivuj meč
            sword.SetActive(true);

            // Vypočítej směr k myši
            Vector3 mouseScreenPos = Input.mousePosition;
            mouseScreenPos.z = Mathf.Abs(mainCamera.transform.position.z);
            Vector3 mouseWorldPos = mainCamera.ScreenToWorldPoint(mouseScreenPos);
            Vector2 direction = (mouseWorldPos - transform.position).normalized;

            // Posuň meč (nastaví pozici relativně vůči hráči)
            sword.transform.localPosition = direction * moveDistance;
            
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            sword.transform.rotation = Quaternion.Euler(0f, 0f, angle);
            _animator.SetBool("swing", true);
        }
        dmgText.text = hitdamage.ToString();
    }
    public void dmgupgrade(float damage)
    {
        hitdamage += damage;
    }
}
