using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuCriacao : MenuBehaviour<MenusMain>
{
    public override void OnStart()
    {
        // // Designa comportamento de botoes
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-atelie", BtAtelie);
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-arquivo", BtArquivo);
        UIToolkitUtils.AssingButtonClick(GetUIDocument(), "bt-voltar", BtVoltar);
    }


    private void BtAtelie(ClickEvent ev)
    {
        Debug.Log("Navegar para cena: Atelie");
    }


    private void BtArquivo(ClickEvent ev)
    {
        Debug.Log("Navegar para cena: Arquivo");
    }


    private void BtVoltar(ClickEvent ev)
    {
        NavegarPara(MenusMain.MAIN);
    }
}
