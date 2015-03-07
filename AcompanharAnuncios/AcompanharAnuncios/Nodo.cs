using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcompanharAnuncios
{
    public class Nodo
    {
        public Nodo Pai
        {
            get;
            set;
        }
        public List<Nodo> Filhos
        {
            get;
            set;
        }

        public String Nome { get; set; }
        public String Link { get; set; }
        
        public Nodo(String nome,string link)
        {
            Nome = nome;
            Link = link;
        }
        void AdicionarFilho(Nodo filho)
        {
            Filhos.Add(filho);
        }

        bool RemoverFilho(Nodo filho)
        {
            if(filho.Pai!=null)
                filho.Pai.Filhos.Remove(filho);
            return Filhos.Remove(filho);
        }
    }
}
