using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Draw_Engine : MonoBehaviour
{
    public Camera m_camera;
    public Color startAtual;
    public Color endAtual;
    public GameObject brush;
    LineRenderer currentLineRenderer;
    Vector2 lastPos;
    public float lineWidth = 0.1f;
    public Rect drawingArea = new Rect(184, 761, 600, 600);
    bool IsWithinDrawingArea()
    {
        Vector2 mousePos = Input.mousePosition;
        return drawingArea.Contains(mousePos);
    }
    
    void Drawing()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrush();
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(mousePos, lastPos) > 0.1f)
            {
                AddPoint(mousePos);
                lastPos = mousePos;
            }
        }
        else 
        {
            currentLineRenderer = null;
        }
    }
public void ClearBrushInstances()
{
    // Encontre todos os objetos do tipo brush (assumindo que brush é um prefab com um componente específico, como LineRenderer)
    LineRenderer[] lineRenderers = FindObjectsOfType<LineRenderer>();
    
    foreach (LineRenderer lineRenderer in lineRenderers)
    {
        Destroy(lineRenderer.gameObject);
    }

    Debug.Log("Todas as instâncias da brush foram apagadas.");
}
    public void IncreaseLineWidth()
{
    lineWidth += 0.05f; // Aumenta a largura em 0.05 ou o valor que você preferir
    if (currentLineRenderer != null)
    {
        currentLineRenderer.startWidth = lineWidth;
        currentLineRenderer.endWidth = lineWidth;
    }
}
    public void DecreaseLineWidth()
{
    lineWidth -= 0.05f; // Diminui a largura em 0.05 ou o valor que você preferir
    if (currentLineRenderer != null)
    {
        currentLineRenderer.startWidth = lineWidth;
        currentLineRenderer.endWidth = lineWidth;
    }
}
    
    public void MudarCor(Color cor)
    {
        startAtual = cor;
        endAtual = cor;
    }
    
    void CreateBrush()
{
    GameObject brushInstance = Instantiate(brush);
    brushInstance.layer = LayerMask.NameToLayer("TheStrokes");
    currentLineRenderer = brushInstance.GetComponent<LineRenderer>();

    if (currentLineRenderer != null)
    {
        currentLineRenderer.numCapVertices = 5; 
        currentLineRenderer.numCornerVertices = 5; 
        currentLineRenderer.startColor = startAtual;
        currentLineRenderer.endColor = endAtual;

        currentLineRenderer.startWidth = lineWidth;
        currentLineRenderer.endWidth = lineWidth;

        Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
        currentLineRenderer.SetPosition(0, mousePos);
        currentLineRenderer.SetPosition(1, mousePos);
    }
    else
    {
        Debug.LogError("LineRenderer não foi encontrado no brushInstance!");
    }
}

    
    void AddPoint(Vector2 pointPos)
{
    if (currentLineRenderer != null)
    {
        currentLineRenderer.positionCount++;
        int positionIndex = currentLineRenderer.positionCount - 1;
        currentLineRenderer.SetPosition(positionIndex, pointPos);
    }
    else
    {
        Debug.LogWarning("currentLineRenderer está nulo");
    }
}
    void Start()
    {
        
    }

   
    void Update()
    {
        if (IsWithinDrawingArea())
        {
            Drawing();  
        }
    }
}
