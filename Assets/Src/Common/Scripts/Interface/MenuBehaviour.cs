using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


/// <summary>
///     Classe <c> MenuBehaviour </c> define comportamento de objetos Menu, que contém um  componente <c> UIDocument </c> e são gerenciadas por um <c> MenuManagerBehaviour </c>.
///     Devem ser usadas em conjunto com um <c> MenuManagerBehaviour </c>, a fim de ser gerido junto com objetos irmãos. 
/// </summary>
/// <typeparam name="TT"> Enumerador representando todos os Menus (i.e. todos os objetos irmãos). </typeparam>
public abstract class MenuBehaviour<TT> : MonoBehaviour where TT : System.Enum
{
    [SerializeField]
    private TT enumerador;

    [SerializeField]
    private MenuManagerBehaviour<TT> manager;

    private UIDocument uiDocument;

    void Start()
    {
        uiDocument = gameObject.GetComponent<UIDocument>();

        if (uiDocument == null)
            Debug.LogWarning("UIDocument nao encontrado");

        OnStart();
    }

    /// <summary>
    ///     Metodo chamado em <c> void Start() </c> de <c> MonoBehaviour </c>.
    ///     <c> Start() </c> não deve ser sobrescrito, ao invés disso, sobreescreva esta função para executar código ao inicializar. 
    /// </summary>
    public virtual void OnStart() { }


    /// <summary>
    ///     Getter para <c> enumerador </c>, valor que representa este objeto.
    /// </summary>
    /// <returns> O valor do enumerador. </returns>
    public TT GetEnumerador() { return enumerador; }


    /// <summary>
    ///     Getter para o <c> UIDocument </c> deste objeto
    /// </summary>
    /// <returns> A referencia para o UIDocument </returns>
    public UIDocument GetUIDocument() { return uiDocument; }

    /// <summary>
    ///     Navega a partir deste menu, para outro.
    ///     Efetivamente, chama <c> MenuManagerBehaviour.Navegar </c> para navegar deste menu para outro.
    /// </summary>
    /// <param name="para"> Representa para qual menu será navegado. </param>
    public void NavegarPara(TT para)
    {
        manager.Navegar(enumerador, para);
    }


    /// <summary>
    ///     Função usada ao navegar de outro menu para este.
    ///     Pode ser sobrescrita, mas DEVE realizar a operação <c> GetUIDocument().rootVisualElement.style.display = DisplayStyle.Flex; </c>. 
    /// </summary>
    /// <param name="de"> Representa de onde foi navegado. </param>
    public virtual void Habilitar(TT de)
    {
        GetUIDocument().rootVisualElement.style.display = DisplayStyle.Flex;
    }

    /// <summary>
    ///     Função usada ao navegar deeste menu para outro.
    ///     Pode ser sobrescrita, mas DEVE realizar a operação <c> GetUIDocument().rootVisualElement.style.display = DisplayStyle.None; </c>.
    /// </summary>
    public virtual void Desabilitar()
    {
        GetUIDocument().rootVisualElement.style.display = DisplayStyle.None; 
    }
}
