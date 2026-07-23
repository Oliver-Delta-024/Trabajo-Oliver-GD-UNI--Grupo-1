using UnityEngine;

public class Muro : MonoBehaviour
{
    [Header("Resistencia del muro")]
    public int resistenciaMaxima = 15;

    private int resistenciaActual;

    void Start()
    {
        resistenciaActual = resistenciaMaxima;
    }

    //==========================================
    // COMBATE
    //==========================================

    public void RecibirDanio(int dano)
    {
        resistenciaActual -= dano;

        Debug.Log(
            "Muro recibió " +
            dano +
            " de daño. Resistencia restante: " +
            resistenciaActual);

        if (resistenciaActual <= 0)
        {
            DestruirMuro();
        }
    }

    void DestruirMuro()
    {
        Debug.Log("El muro fue destruido.");

        Destroy(gameObject);
    }

    //==========================================
    // DATOS PARA EL GUARDADO
    //==========================================

    // Vida actual del muro
    public int ObtenerResistencia()
    {
        return resistenciaActual;
    }

    // Posición donde fue colocado
    public Vector2 ObtenerPosicion()
    {
        return transform.position;
    }

    // Restaurar únicamente la vida
    public void RestaurarResistencia(int resistencia)
    {
        resistenciaActual = resistencia;
    }

    // Restaurar posición y vida
    public void RestaurarMuro(Vector2 posicion, int resistencia)
    {
        transform.position = posicion;
        resistenciaActual = resistencia;
    }

    // Saber si el muro sigue existiendo
    public bool EstaDestruido()
    {
        return resistenciaActual <= 0;
    }
}
