using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaManagement : MonoBehaviour
{

    private static int vidaM�xima = 3;
    private static int vidaActual;
    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaM�xima;
    }

    public void RestarVida(int damage)
    {
        vidaActual -= damage;
    }
}
