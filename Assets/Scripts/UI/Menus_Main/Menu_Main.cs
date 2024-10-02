using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Main : Menu
{
    [Header("Referencias: outros Menus")]
    public GameObject menu_encontrar_batalha = null;
    public GameObject menu_colecao = null;
    public GameObject menu_opcoes = null;

    [Header("Referencias: outras Cenas")]
    public string cena_criar = null;

    void Start()
    {
        checkMenu(menu_encontrar_batalha);
        checkMenu(menu_colecao);
        checkMenu(menu_opcoes);
        
        checkCena(cena_criar);
    }

    // Menus
    public void encontrarBatalha() { navegarMenuLocal(menu_encontrar_batalha); }
    public void dex() { navegarMenuLocal(menu_colecao); }
    public void opcoes() { navegarMenuLocal(menu_opcoes); }
    
    // Cenas
    public void criar() { Debug.Log("fon (criar)"); }

    // Outros
    public void sair() { Application.Quit(); }
}
