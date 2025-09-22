using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuSaguao : MenuBehaviour<MenusSaguao>
{
    public override void OnStart()
    {
        // Designa comportamento de botoes
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-conferir-time", BtConferirTime);
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-sair", BtSair);
    }


    private void BtConferirTime(ClickEvent ev)
    {
        NavegarPara(MenusSaguao.TIME);
    }


    private void BtSair(ClickEvent ev)
    {
        Debug.Log("BtSair: ir para cena menu");
    }
}
