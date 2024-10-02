using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Time : Menu
{
    [Header("Referencias: outros Menus")]
    public GameObject menu_lobby = null;
    
    void Start()
    {
        checkMenu(menu_lobby);   
    }
    
    // Menus
    public void voltar() { navegarMenuLocal(menu_lobby); }
}
