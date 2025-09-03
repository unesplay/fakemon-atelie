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
        AssingButtonClick("bt-voltar", BtVoltar);
    }


    private void AssingButtonClick(string btName, EventCallback<ClickEvent> callback)
    {
        Button bt = uiDocument.rootVisualElement.Query<Button>(btName).First();

        if (bt != null)
            bt.RegisterCallback<ClickEvent>(callback);
        else
            Debug.LogWarning("AssingButtonClick: botao '" + btName + "' nao encontrado");
    }


    private void BtVoltar(ClickEvent ev)
    {
        manager.Navegar(this.GetEnumerador(), MenusSaguao.SAGUAO);
    }
}