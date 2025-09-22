using UnityEngine.UIElements;
using UnityEngine;

public static class UIToolkitUtils
{
    public static void AssingButtonClick(UIDocument uiDoc, string btName, EventCallback<ClickEvent> callback)
    {
        if(uiDoc == null)
            Debug.LogWarning("AssingButtonClick: uidoc eh null");

        Button bt = uiDoc.rootVisualElement.Query<Button>(btName).First();

        if (bt != null)
            bt.RegisterCallback<ClickEvent>(callback);
        else
            Debug.LogWarning("AssingButtonClick: botao '" + btName + "' nao encontrado");
    }
}