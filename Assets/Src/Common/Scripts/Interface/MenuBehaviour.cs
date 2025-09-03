using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


/// <summary>
///     Objetos "Menu" (com UI Documents) devem implementar esta interface para funcionarem corretamente com o MenuManagerBehaviour
/// </summary>
/// <typeparam name="TT"> Enum referente aos menus irmãos </typeparam>
public abstract class MenuBehaviour<TT> : MonoBehaviour where TT : System.Enum
{
    [SerializeField]
    private TT enumerador;

    [SerializeField]
    protected MenuManagerBehaviour<TT> manager;

    protected UIDocument uiDocument;

    void Start()
    {
        uiDocument = gameObject.GetComponent<UIDocument>();

        if (uiDocument == null)
            Debug.LogWarning("UIDocument nao encontrado");

        OnStart();
    }


    public virtual void OnStart() { }


    public TT GetEnumerador() { return enumerador; }


    /// <summary>
    ///     Define comportamento ao ser habilitada, i.e. quando se navega para este menu. 
    ///     DEVE chamar gameObject.SetActive(true).
    /// </summary>
    /// <param name="de"> qual a fonte deste evento de navegacao </param>
    public virtual void Habilitar(TT de)
    {
        uiDocument.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    /// <summary>
    ///     Define comportamento ao ser desabilitada, i.e. quando se navega deste menu para outro. 
    ///     DEVE chamar gameObject.SetActive(false).
    /// </summary>
    public virtual void Desabilitar()
    {
        uiDocument.rootVisualElement.style.display = DisplayStyle.None; 
    }
}
