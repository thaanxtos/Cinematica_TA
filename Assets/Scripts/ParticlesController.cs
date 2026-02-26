using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ParticulasController : MonoBehaviour
{
    public int nP; //numero de particulas
    public float v0P; //velocidad inicial de las particulas
    public float angulo0P; //angulo incial de las particulas
    public float tLP; //tiempo de vida (life) de las particulas
    public float gP; //gravedad de las particulas
    GameObject Particulas;

    void Start() //añadir array con particulas
    {
        Particulas p = new Particulas();
        CreateParticleExplosion(new List<GameObject>());
    }
    
    void Update() //actualizar el array 
    {
        UpdateParticlePositions(new Particulas(), Time.deltaTime);
    }

    void CreateParticleExplosion(List<GameObject> particleList)
    {
        particleList = new List<GameObject>();
        for (int i = 0; i < nP; i++) //añadir particulas a la lista según nP
        {
            GameObject particle = new GameObject("Particula" + i);
            particle.AddComponent<Particulas>();
            particleList.Add(particle);
        }
    }

    void UpdateParticlePositions(Particulas p, float time)
    {
        time = time * Time.deltaTime;
    }
}
