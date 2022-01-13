using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManager1 : MonoBehaviour
{
    public int SceneIndex;

    public void Move()
    {
        SceneManager.LoadScene(SceneIndex);
    }
    
    
}
