using UnityEngine.InputSystem;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class ParticulasController : MonoBehaviour
{
    public int nP; //numero de particulas
    public float v0P; //velocidad inicial de las particulas
    public float angulo0P; //angulo incial de las particulas
    public float tLP0; //tiempo de vida (life) inicial de las particulas
    public float gP; //gravedad de las particulas
    public GameObject Particulas; //prefab de la particula
    Particulas ultimaPart; //referencia a la ultima particula creada

    public void onActivate(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            CreateParticleExplosion();
        }
    }

    void CreateParticleExplosion()
    {
        for (int i = 0; i < nP; i++)
        {
            ultimaPart = Instantiate(Particulas, transform).GetComponent<Particulas>();
            //el random range inicial es la variacion del angulo
            float angulo = angulo0P + Random.Range(5f, 50f) * Mathf.Sqrt(-2f * Mathf.Log(Random.value)) * Mathf.Cos(2f * Mathf.PI * Random.value); 
            float velocidad = Mathf.Max(v0P + Random.Range(-5f, 5f) * Mathf.Sqrt(-2f * Mathf.Log(Random.value)) * Mathf.Cos(2f * Mathf.PI * Random.value), 0f);
            float tiempoVida = tLP0 + Random.Range(-1f, 1f) * Mathf.Sqrt(-2f * Mathf.Log(Random.value)) * Mathf.Cos(2f * Mathf.PI * Random.value);
            ultimaPart.SetValues(this, velocidad, angulo, tiempoVida, gP);
        }
    }

    public void UpdateParticlePositions(Particulas p, float time)
    {
        if(p.tT < time)
        {
            p.gameObject.SetActive(false);
            return;
        }

        Vector3 newPosition = p.transform.position;
        newPosition.x = p.v0X * time;
        newPosition.y = (p.v0Y * time) - (p.g * time * time/2);
        p.transform.position = newPosition;
    }
}
