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
        currentLineRenderer.startColor = startAtual;
        currentLineRenderer.endColor = endAtual;

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
