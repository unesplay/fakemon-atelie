using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Opcoes : Menu
{
    [Header("Referencias: outros Menus")]
    public GameObject menu_main = null;

    void Start()
    {
        checkMenu(menu_main);
    }

    // Menus
    public void voltar() { navegarMenuLocal(menu_main); }
}
