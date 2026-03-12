using UnityEngine;

public class Particulas : MonoBehaviour
{
    ParticulasController controller;
    public float v0X, v0Y; //velocidad inicial en x e y
    public float angulo0; //angulo incial
    public float tM; //tiempo de vida maximo
    public float tA; //tiempo que lleva la particula activa
    public float tT; //tiempo total
    public float g; //gravedad

    public void SetValues(ParticulasController controller, float v0P, float angulo0P, float tLP0, float gP)
    { 
        this.controller = controller;
        this.angulo0 = angulo0P;
        this.tM = tLP0;
        this.tA = tLP0;
        this.g = gP;
        this.v0X = v0P * Mathf.Cos(angulo0P * Mathf.Deg2Rad);
        this.v0Y = v0P * Mathf.Sin(angulo0P * Mathf.Deg2Rad);
     
        tT = 0;
    }
    
    void Update() 
    {
        tT += Time.deltaTime;
        controller.UpdateParticlePositions(this, tT);
    }
}
