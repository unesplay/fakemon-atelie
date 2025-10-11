using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuConfiguracoes : MenuBehaviour<MenusMain>
{
    public override void OnStart()
    {
        // // Designa comportamento de botoes
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-voltar", BtVoltar);
    }


    private void BtVoltar(ClickEvent ev)
    {
        NavegarPara(MenusMain.MAIN);
    }
}
