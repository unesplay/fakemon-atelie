using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuMain : MenuBehaviour<MenusMain>
{
    public override void OnStart()
    {
        // Designa comportamento de botoes
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-criar", BtCriar);
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-batalhar", BtBatalhar);
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-config", BtConfig);
    }


    private void BtCriar(ClickEvent ev)
    {
        NavegarPara(MenusMain.CRIACAO);
    }


    private void BtBatalhar(ClickEvent ev)
    {
        Debug.Log("BtbATALHAR: ir para cena saguao");
    }


    private void BtConfig(ClickEvent ev)
    {
        NavegarPara(MenusMain.CONFIGURACOES);
    }
}