using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CriacaoNavigationManager : MenuManagerBehaviour<TabsCriacao>
{
    private UIDocument uiDoc;

    public override void OnStart()
    {
        uiDoc = gameObject.GetComponent<UIDocument>();

        if (uiDoc == null)
            Debug.LogWarning("uiDocument nao encontrado");

        UIToolkitUtils.AssingButtonClick(uiDoc, "bt-atributos", BtAtributos);
        UIToolkitUtils.AssingButtonClick(uiDoc, "bt-caracteristicas", BtCaracteristicas);
        UIToolkitUtils.AssingButtonClick(uiDoc, "bt-habilidades", BtHabilidades);
    }


    void BtAtributos(ClickEvent ev)
    {
        SetMenuAtual(TabsCriacao.ATRIBUTOS);
    }


    void BtCaracteristicas(ClickEvent ev)
    {
        SetMenuAtual(TabsCriacao.CARACTERISTICAS);
    }


    void BtHabilidades(ClickEvent ev)
    {
        SetMenuAtual(TabsCriacao.HABILIDADES);
    }
}


public enum TabsCriacao
{
    ATRIBUTOS,
    CARACTERISTICAS,
    HABILIDADES
}
