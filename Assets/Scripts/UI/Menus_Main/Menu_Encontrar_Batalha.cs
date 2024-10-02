using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Encontrar_Batalha : Menu
{
    [Header("Referencias: outros Menus")]
    public GameObject menu_main = null;

    [Header("Referencias: outras Cenas")]
    public string cena_lobby = null;

    void Start()
    {
        checkMenu(menu_main);
        
        checkCena(cena_lobby);
    }

    // Menus
    public void voltar() { navegarMenuLocal(menu_main); }

    // Cenas
    public void Hospedar() { Debug.Log("hospedar"); }
    public void Entrar() { Debug.Log("entrar"); }

}
