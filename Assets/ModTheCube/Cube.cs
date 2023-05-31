using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        float randomX = Random.Range(-5f, 5f); // Gera um valor aleatório para a coordenada X
        float randomY = Random.Range(-5f, 5f); // Gera um valor aleatório para a coordenada Y
        float randomZ = Random.Range(-5f, 5f); // Gera um valor aleatório para a coordenada Z
        transform.position = new Vector3(randomX, randomY, randomZ);
        
        float randomScale = Random.Range(1f, 3f); // Gera um valor aleatório para a escala
        transform.localScale = Vector3.one * randomScale;
        
        Material material = Renderer.material;
        
        float randomR = Random.Range(0f, 1f); // Gera um valor aleatório para o componente R (vermelho) da cor
        float randomG = Random.Range(0f, 1f); // Gera um valor aleatório para o componente G (verde) da cor
        float randomB = Random.Range(0f, 1f); // Gera um valor aleatório para o componente B (azul) da cor
        float randomA = Random.Range(0f, 1f); // Gera um valor aleatório para o componente A (alfa) da cor
        material.color = new Color(randomR, randomG, randomB, randomA);
    }
    
    void Update()
    {
        transform.Rotate(11.0f * Time.deltaTime, 0.5f, 0.5f);
    }
}
