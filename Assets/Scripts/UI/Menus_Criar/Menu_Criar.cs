using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Criar : Menu
{
    [Header("Referencias: outras Cenas")]
    public string cena_main = null;
    
    void Start()
    {
        checkCena(cena_main);  
    }
    
    // Cenas
    public void sair() { Debug.Log("fon (sair)"); }

    
    // Outros
    public void pronto() { Debug.Log("fon (pronto)"); }
}