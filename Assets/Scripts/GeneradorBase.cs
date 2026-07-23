using UnityEngine;

public abstract class GeneradorBase : MonoBehaviour
{
    public abstract void ActivarRalentizacion(float multiplicador);
    public abstract void DesactivarRalentizacion();

    public abstract void ActivarOverdrive(float multiplicador);
    public abstract void DesactivarOverdrive();
}
