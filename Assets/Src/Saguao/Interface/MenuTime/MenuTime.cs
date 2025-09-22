using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuTime : MenuBehaviour<MenusSaguao>
{
    public override void OnStart()
    {
        // Designa comportamento de botoes
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-voltar", BtVoltar);
    }
    

    private void BtVoltar(ClickEvent ev)
    {
        NavegarPara(MenusSaguao.SAGUAO);
    }
}