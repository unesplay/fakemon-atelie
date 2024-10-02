using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Lobby : Menu
{
    [Header("Referencias: outros Menus")]
    public GameObject menu_time = null;

    [Header("Referencias: outras Cenas")]
    public string cena_main = null;
    public string cena_batalha = null;
    
    void Start()
    {
        checkMenu(menu_time);
        
        checkCena(cena_main);
        checkCena(cena_batalha);        
    }
    
    // Menus
    public void time() { navegarMenuLocal(menu_time); }

    
    // Cenas
    public void sair() { Debug.Log("fon (sair)"); }

    
    // Outros
    public void pronto() { Debug.Log("fon (pronto)"); }
}
