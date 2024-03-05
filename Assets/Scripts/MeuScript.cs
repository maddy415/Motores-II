using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 5- Crie uma classe Celular, defina seus atributos,
 * crie o construtor e em seguida crie um objeto com a classe celular e mostre as informações dele no Console.

 */
public class MeuScript : MonoBehaviour
{
    public List<string> personagens = new List<string>();

    Celular samsung;
    
    private Rigidbody2D rb; 
    
    public Vector2 pos;
    
    // Start is called before the first frame update
    void Start()
    {
        personagens.Add("Solanum"); //pos 0
        personagens.Add("Feldspar"); //pos 1
        personagens.Add("Gossan"); //pos 2
        personagens.Add("Riebeck"); //pos 3
        personagens.Add("Slate"); //pos 4
        
        personagens.RemoveAt(3); //Removeu Riebeck
        personagens.Remove("Feldspar"); //Removeu Feldspar
        personagens.Insert(1, "Hornfels"); //Sobscrever a posição 1. Feldspar --> Hornfels

        foreach (string personagem in personagens) //Percorrer a lista
        {
            Debug.Log(personagem);
        }

        samsung = new Celular(35,15.2f); //Objeto do celular
        Debug.Log($"A bateria do celular é: {samsung.bateria}%\nO tamanho do celular é: {samsung.tamanho}"); //Mensagem

        TryGetComponent<Rigidbody2D>(out rb);
        Debug.Log($"A massa é: {rb.mass}"); //Mostrar a massa no Console

        pos = new Vector2(2f, 4f); 
        transform.position = pos; //Posição do quadrado: 0, 0 ---> 2, 4.
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class Celular
    {
        public int bateria;
        public float tamanho;

        public Celular(int celularBateria, float celularTamanho)
        {
            this.bateria = celularBateria;
            this.tamanho = celularTamanho;
        }
    }
}
