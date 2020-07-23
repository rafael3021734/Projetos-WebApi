using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{

    public class Alunos
    {
       public int id{get; set;}
       public string nome{get; set;} 
       public string sobrenome {get; set;}
       public string Telefone {get; set;}
       public int ra {get; set;}
       public List<Alunos> listaAlunos{get; set;}
       
        }    
}