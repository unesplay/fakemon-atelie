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
        AssingButtonClick("bt-prosseguir", BtProsseguir);
        AssingButtonClick("bt-sair", BtSair);
    }


    private void AssingButtonClick(string btName, EventCallback<ClickEvent> callback)
    {
        Button bt = GetUIDocument().rootVisualElement.Query<Button>(btName).First();

        if (bt != null)
            bt.RegisterCallback<ClickEvent>(callback);
        else
            Debug.LogWarning("AssingButtonClick: botao '" + btName + "' nao encontrado");
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