using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;

    public GameObject loseScreen;
    public GameObject score;
    public GameObject menuIcon;

    public float restartDelay = 3f;
    public void EndGame() {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            //Debug.Log("GAME OVER");
            menuIcon.SetActive(false);
            loseScreen.SetActive(true);   
            score.SetActive(false);
            Invoke("Restart", restartDelay);
        }

    
    }

    void Restart () 
    {
        loseScreen.SetActive(false);
        score.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
