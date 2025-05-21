using UnityEngine;
using UnityEngine.SceneManagement;
public class points : MonoBehaviour
{
    public gameoverscr win;
    public int kills = 0;
    public void addpoint()
    {
        kills++;
        if (kills >= 3)
        {
            win.gameObject.SetActive(true);
        }
    }
}
