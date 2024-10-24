using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        novaCor = new Color32(0x0F, 0x0F, 0x04, 0xFF); 
        Draw.GetComponent<Draw_Engine>().MudarCor(novaCor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Color novaCor;
    public GameObject[] botoes;
    public Color startAtual;
    public Color endAtual;
    public GameObject Draw;
    public void MudarCor(string Cor)
    {
        Debug.Log(Cor);
        switch (Cor)
        { 
            case "Vermelho":
                novaCor = new Color32(0xD2, 0x4C, 0x3A, 0xFF); 
                Draw.GetComponent<Draw_Engine>().MudarCor(novaCor);
                break;
            case "Azul":
                novaCor = new Color32(0x70, 0xAA, 0xAC, 0xFF); 
                Draw.GetComponent<Draw_Engine>().MudarCor(novaCor);
                break;
            case "Verde":
                novaCor = new Color32(0x79, 0xA2, 0x6A, 0xFF);
                Draw.GetComponent<Draw_Engine>().MudarCor(novaCor);
                break;
            case "Amarelo":
                novaCor = new Color32(0xF4, 0xF1, 0xBB, 0xFF);
                Draw.GetComponent<Draw_Engine>().MudarCor(novaCor);
                break;
            case "Preto":
                novaCor = new Color32(0x0F, 0x0F, 0x04, 0xFF);
                Draw.GetComponent<Draw_Engine>().MudarCor(novaCor);
                break;
            case "Branco":
                novaCor = new Color32(0xE3, 0xDE, 0xE7, 0xFF);
                Draw.GetComponent<Draw_Engine>().MudarCor(novaCor);
                break;
            case "Rosa":
                novaCor = new Color32(0xD8, 0x9C, 0xD3, 0xFF);
                Draw.GetComponent<Draw_Engine>().MudarCor(novaCor);
                break;
            case "Laranja":
                novaCor = new Color32(0xDF, 0x80, 0x41, 0xFF);
                Draw.GetComponent<Draw_Engine>().MudarCor(novaCor);
                break;
            case "Roxo":
                novaCor = new Color32(0x85, 0x70, 0xC2, 0xFF);
                Draw.GetComponent<Draw_Engine>().MudarCor(novaCor);
                break;
            case "Ciano":
                novaCor = new Color32(0x7C, 0xD8, 0xC1, 0xFF);
                Draw.GetComponent<Draw_Engine>().MudarCor(novaCor);
                break;
            case "Aleatorio":
            default:
                Draw.GetComponent<Draw_Engine>().MudarCor(new Color(Random.value, Random.value, Random.value));
                break;
        }
    }
    public void desativarBotao(GameObject botao)
    {
        botao.GetComponent<Button>().interactable = false;
        foreach (GameObject b in botoes)
        {
            if (b != botao)
            {
                b.GetComponent<Button>().interactable = true;
            }
        }
    }
}
