using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
///     Classe <c> MenuManagerBehaviour </c> Realiza a gestão de navegação de objetos Menu, que contém um  componente <c> UIDocument </c> e um <c> MenuBehaviour </c>. 
///     Devem ser usadas em conjunto com um <c> MenuBehaviour </c>, a fim de gerir todos os objetos filhos. 
/// </summary>
/// <typeparam name="TT"> Enumerador representando todos os Menus (i.e. todos os objetos irmãos). </typeparam>
/// 
[DefaultExecutionOrder(1)]
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

    /// <summary>
    ///     Metodo chamado em <c> void Start() </c> de <c> MonoBehaviour </c>.
    ///     <c> Start() </c> não deve ser sobrescrito, ao invés disso, sobreescreva esta função para executar código ao inicializar. 
    /// </summary>
    public virtual void OnStart() { }


    /// <summary>
    ///     Getter para <c> menuAtual </c>, valor que representa menu atualmente selecionado.
    /// </summary>
    /// <returns> O valor do enumerador. </returns>
    public virtual TT GetMenuAtual() { return menuAtual; }

    /// <summary>
    ///     Setter para <c> menuAtual </c>.
    ///     Utilizar esta função também habilita o menu representado por <c> menu </c> e desabilita os demais.
    /// </summary>
    /// <param name="menu"> Valor a ser definido. Representa um menu. </param>
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


    /// <summary>
    ///     Navega de um menu para outro.
    ///     Efetivamente, desabilita um objeto menu, e habilita outro em seu lugar.
    ///     Ambos são representados por seu respectivo enumerador.
    /// </summary>
    /// <param name="de"> Representa de qual menu será navegado. </param>
    /// <param name="para"> Representa para qual menu será navegado. </param>
    /// <exception cref="Exception"> Arremessada caso não seja possivel navegar, devido ao fato de um dos menus não estar definido. </exception>
    public virtual void Navegar(TT de, TT para)
    {
        if (menusDict.ContainsKey(de) && menusDict.ContainsKey(para))
        {
            menusDict[de].Desabilitar();
            menusDict[para].Habilitar(de);

            // deliberadamente nao utiliza o setter, pois este metodo tambem age como um tipo de setter para menuAtual
            menuAtual = para;
        }
        else
        {
            throw new Exception("impossivel navegar de " + de + "  para " + para + ": menu nao definido");
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