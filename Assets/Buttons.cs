using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Draw.GetComponent<Draw_Engine>().MudarCor(Color.black);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject[] botoes;
    
    public Color startAtual;
    public Color endAtual;
    public GameObject Draw;
    public void MudarCor(string Cor)
    {
        switch (Cor)
        {
            case "Vermelho":
                Draw.GetComponent<Draw_Engine>().MudarCor(Color.red);
                break;
            case "Azul":
                Draw.GetComponent<Draw_Engine>().MudarCor(Color.blue);
                break;
            case "Verde":
                Draw.GetComponent<Draw_Engine>().MudarCor(Color.green);
                break;
            case "Amarelo":
                Draw.GetComponent<Draw_Engine>().MudarCor(Color.yellow);
                break;
            case "Preto":
                Draw.GetComponent<Draw_Engine>().MudarCor(Color.black);
                break;
            case "Branco":
                Draw.GetComponent<Draw_Engine>().MudarCor(Color.white);
                break;
            case "Rosa":
                Draw.GetComponent<Draw_Engine>().MudarCor(Color.magenta);
                break;
            case "Laranja":
                Draw.GetComponent<Draw_Engine>().MudarCor(new Color(1, 0.5f, 0));
                break;
            case "Roxo":
                Draw.GetComponent<Draw_Engine>().MudarCor(new Color(0.5f, 0, 0.5f));
                break;
            case "Ciano":
                Draw.GetComponent<Draw_Engine>().MudarCor(Color.cyan);
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
