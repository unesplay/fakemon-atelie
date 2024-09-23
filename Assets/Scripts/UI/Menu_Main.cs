using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Main : Menu
{
    [Header("referencias a outros menus")]
    public GameObject menu_opcoes = null;

    void Start()
    {
        if(menu_opcoes == null){ Debug.LogWarning("objeto de referencia Menu_Opcoes nao esta settado em " + gameObject.name); }
    }

    public void batalhar() { Debug.Log("fon (batalhar)"); }
    public void criar() { Debug.Log("fon (criar)"); }
    public void dex() { Debug.Log("fon (dex)"); }
    public void opcoes() { navegarMenuLocal(menu_opcoes); }
    public void sair() { Application.Quit(); }
}
