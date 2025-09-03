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
        AssingButtonClick("bt-conferir-time", BtConferirTime);
        AssingButtonClick("bt-sair", BtSair);
    }


    private void AssingButtonClick(string btName, EventCallback<ClickEvent> callback)
    {
        Button bt = uiDocument.rootVisualElement.Query<Button>(btName).First();

        if (bt != null)
            bt.RegisterCallback<ClickEvent>(callback);
        else
            Debug.LogWarning("AssingButtonClick: botao '" + btName + "' nao encontrado");
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
