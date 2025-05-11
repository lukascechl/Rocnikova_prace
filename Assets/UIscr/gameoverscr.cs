using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gameoverscr : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public void RestartButton(){
    SceneManager.LoadScene("SampleScene");
}

}
