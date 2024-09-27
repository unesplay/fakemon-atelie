using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Lobby : Menu
{
    [Header("Referencias: outros Menus")]
    public GameObject menu_time = null;

    [Header("Referencias: outras Cenas")]
    public GameObject cena_main = null;
    
    void Start()
    {
        if(menu_time == null){ Debug.LogWarning("objeto de referencia Menu_Time nao esta settado em " + gameObject.name); }
    }
    
    // Menus
    public void time() { navegarMenuLocal(menu_time); }
}
