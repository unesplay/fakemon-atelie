using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Opcoes : Menu
{
    [Header("referencias a outros menus")]
    public GameObject menu_main = null;

    void Start()
    {
        if(menu_main == null){ Debug.LogWarning("objeto de referencia Menu_Main nao esta settado em " + gameObject.name); }
    }

    public void voltar() { navegarMenuLocal(menu_main); }
}
