using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    protected void navegarMenuLocal(GameObject target)
    {
        gameObject.SetActive(false);
        target.SetActive(true);
    }

    protected void navegarCena(string target)
    {
        SceneManager.LoadSceneAsync(target, LoadSceneMode.Single);
    }

}
