using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OpenDishesCategory(string dishesCategory)
    {
        PlayerPrefs.SetString("SelectedDishCategory", dishesCategory);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Dishes");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
