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
        brushInstance.GetComponent<LineRenderer>().startColor = startAtual;
        brushInstance.GetComponent<LineRenderer>().endColor = endAtual;

        currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
        Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);

        currentLineRenderer.SetPosition(0, mousePos);
        currentLineRenderer.SetPosition(1, mousePos);
    }
    
    void AddPoint(Vector2 pointPos)
    {
        currentLineRenderer.positionCount++;
        int positionIndex = currentLineRenderer.positionCount - 1;
        currentLineRenderer.SetPosition(positionIndex, pointPos);
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        Drawing();
    }
}
