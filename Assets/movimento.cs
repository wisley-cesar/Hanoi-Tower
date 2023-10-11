using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0))
    {
        // Quando o botão esquerdo do mouse é pressionado
        // Verifique se o mouse está sobre um disco no Pino 1 e, se sim, marque o disco como "selecionado".
    }
    
    if (Input.GetMouseButtonUp(0))
    {
        // Quando o botão esquerdo do mouse é liberado
        // Se um disco estiver marcado como "selecionado", verifique se ele pode ser movido para o Pino 2 e, se sim, mova-o.
    }

    }
}
