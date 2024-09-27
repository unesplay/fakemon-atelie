using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Encontrar_Batalha : Menu
{
    [Header("Referencias: outros Menus")]
    public GameObject menu_main = null;

    [Header("Referencias: outras Cenas")]
    public GameObject cena_lobby = null;

    void Start()
    {
        if(menu_main == null){ Debug.LogWarning("objeto de referencia Menu_Main nao esta settado em " + gameObject.name); }

        if(cena_lobby == null){ Debug.LogWarning("objeto de referencia Cena_Lobby nao esta settado em " + gameObject.name); }
    }

    // Menus
    public void voltar() { navegarMenuLocal(menu_main); }

    // Cenas
    public void Hospedar() { Debug.Log("hospedar"); }
    public void Entrar() { Debug.Log("entrar"); }

}
