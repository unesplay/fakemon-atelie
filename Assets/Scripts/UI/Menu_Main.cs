using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Main : Menu
{
    [Header("Referencias: outros Menus")]
    public GameObject menu_batalha = null;
    public GameObject menu_colecao = null;
    public GameObject menu_opcoes = null;

    [Header("Referencias: outras Cenas")]
    public GameObject cena_criar = null;

    void Start()
    {
        if(menu_batalha == null){ Debug.LogWarning("objeto de referencia Menu_Batalha nao esta settado em " + gameObject.name); }
        if(menu_colecao == null){ Debug.LogWarning("objeto de referencia Menu_Colecao nao esta settado em " + gameObject.name); }
        if(menu_opcoes == null){ Debug.LogWarning("objeto de referencia Menu_Opcoes nao esta settado em " + gameObject.name); }

        if(cena_criar == null){ Debug.LogWarning("objeto de referencia Cena_Criar nao esta settado em " + gameObject.name); }
    }

    // Menus
    public void batalhar() { navegarMenuLocal(menu_batalha); }
    public void dex() { navegarMenuLocal(menu_colecao); }
    public void opcoes() { navegarMenuLocal(menu_opcoes); }
    
    // Cenas
    public void criar() { Debug.Log("fon (criar)"); }

    // Outros
    public void sair() { Application.Quit(); }
}
