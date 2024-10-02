using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    protected void checkMenu(GameObject menu) { if(menu == null){ Debug.LogWarning("referencia a um Menu nao esta definida em " + gameObject.name); } }
    protected void checkCena(string cena) { if(cena == null){ Debug.LogWarning("referencia a uma Cena nao esta definida em " + gameObject.name); } }

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
