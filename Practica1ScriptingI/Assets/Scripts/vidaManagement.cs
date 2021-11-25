using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaManagement : MonoBehaviour
{

    private static int vidaMáxima = 3;
    private static int vidaActual;
    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMáxima;
    }

    public void RestarVida(int damage)
    {
        vidaActual -= damage;
    }
}
