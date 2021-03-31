using LanchesMac.Models;
using System.Collections.Generic;

namespace LanchesMac.ViewModels
{
    public class LanchesListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }

    }
}
