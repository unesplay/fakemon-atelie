using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public abstract class MenuManagerBehaviour<TT> : MonoBehaviour where TT : System.Enum
{
    [SerializeField]
    private TT menuAtual;

    [SerializeField]    
    private MenuBehaviour<TT>[] menuObjects;

    [SerializeField]
    private Dictionary<TT, MenuBehaviour<TT>> menusDict;


    void Start()
    {
        // gera dicionario de menus
        menusDict = GerarDictMenus();

        // Atualiza Habilitacao de menus
        SetMenuAtual(menuAtual);

        OnStart();
    }


    public virtual void OnStart() { }


    public virtual TT GetMenuAtual() { return menuAtual; }

    public virtual void SetMenuAtual(TT menu)
    {
        menuAtual = menu;

        // desativa os menus que nao o atual selecionado
        foreach (KeyValuePair<TT, MenuBehaviour<TT>> mm in menusDict)
            if (mm.Key.Equals(menuAtual))
                mm.Value.Habilitar(menuAtual);
            else
                mm.Value.Desabilitar();
    }


    public virtual void Navegar(TT de, TT para)
    {
        if (menusDict.ContainsKey(de) & menusDict.ContainsKey(para))
        {
            menusDict[de].Desabilitar();
            menusDict[para].Habilitar(de);

            // deliberadamente nao utiliza o setter, pois este metodo tambem age como um tipo de setter para menuAtual
            menuAtual = para;
        }
        else
        {
            throw new Exception("impossivel navegar de " + de + "  para " + para);
        }
    }


    private Dictionary<TT, MenuBehaviour<TT>> GerarDictMenus()
    {
        Dictionary<TT, MenuBehaviour<TT>> res = new Dictionary<TT, MenuBehaviour<TT>>();

        // Preenche dict a partir do array
        foreach (MenuBehaviour<TT> mm in menuObjects)
            if (!res.ContainsKey(mm.GetEnumerador()))
                res[mm.GetEnumerador()] = mm;

            else
                Debug.LogWarning("GerarDictMenus: Objeto " + mm + " tem o enumerador " + mm.GetEnumerador() + " repetido");

        // Checagem de seguranca 
        if (Enum.GetNames(typeof(TT)).Length != res.Count)
            Debug.LogWarning("GerarDictMenus: numero de enumeracoes e menus mapeados eh desigual: " + (Enum.GetNames(typeof(TT)).Length - res.Count));

        return res;
    }
}