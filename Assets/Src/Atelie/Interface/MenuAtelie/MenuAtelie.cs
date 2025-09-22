using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuAtelie : MenuBehaviour<MenusAtelie>
{
    public override void OnStart()
    {
        // Designa comportamento de botoes
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-prosseguir", BtProsseguir);
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-sair", BtSair);
    }


    private void BtProsseguir(ClickEvent ev)
    {
        Debug.Log("BtProsseguir");
    }


    private void BtSair(ClickEvent ev)
    {
        Debug.Log("BtSair: ir para cena menu");
    }
}