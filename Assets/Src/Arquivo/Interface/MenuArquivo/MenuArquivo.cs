using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UIElements;


public class MenuArquivo : MenuBehaviour<MenusArquivo>
{
    public override void OnStart()
    {
        // Designa comportamento de botoes
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-sair", BtSair);
    }


    private void BtSair(ClickEvent ev)
    {
        Debug.Log("BtSair: ir para cena menu");
    }
}
