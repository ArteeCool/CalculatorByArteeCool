using UnityEngine;
using UnityEngine.SceneManagement;


public class IntroductionScript : MonoBehaviour
{
    public int Timer;

    private void FixedUpdate()
    {
        if (Time.time > Timer)
        {
            SceneManager.LoadScene(1);
        }
    }
}
