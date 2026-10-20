using System;

namespace TechStoreMVC.Models;

public class Categoria
{
    //Atividade 01 - Criar as Models
    public int Id {get; set;} // Get para obter um id = Indtificador
    public string Nome {get; set;} // Set para definir um novo valor, atualizar e etc.
    public string Descricao {get; set;}
    public bool Ativa  {get; set;}

    // Metodo Construtor
    public Categoria(
        int id,
        string nome,
        string descricao,
        bool ativa
    )
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Ativa = ativa;
    }

    
}
