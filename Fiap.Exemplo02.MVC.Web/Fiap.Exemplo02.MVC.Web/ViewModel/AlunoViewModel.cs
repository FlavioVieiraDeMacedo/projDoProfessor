using Fiap.Exemplo02.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace Fiap.Exemplo02.MVC.Web.ViewModel
{
    public class AlunoViewModel
    {
        public SelectList ListaGrupo { get; set; }
        #region Aluno properties
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Display(Name ="Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        public Nullable<double> Desconto { get; set; }

        public bool Bolsa { get; set; }
        [Display(Name="Grupo")]
        public int GrupoId { get; set; }
        public string Mensagem { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
        public string NomeBusca { get; set; }
        public int? IdBusca { get; set; }
        #endregion
    }
}
