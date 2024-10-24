using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meu_Gaveta : MonoBehaviour
{
    [Header("Referencias: Outras Gavetas")]
    public GameObject[] gavetas = null;
    
    void Start()
    {
        abrirGaveta(0);
    }

    public void abrirGaveta(int gindex)
    {
        if(gindex < 0 || gindex >= gavetas.Length){
            Debug.LogWarning("Tentou abrir uma gaveta que nao existe");
            return;
        }

        for(int ii = 0 ; ii < gavetas.Length; ii++){
            gavetas[ii].SetActive(ii == gindex);
        }
    }
    
}