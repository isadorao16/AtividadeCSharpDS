using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDejogos.Classes
{
    internal class Jogo
    {
        
        String titulo;
        int ano;
        String genero;
        int maxJogadores;
        int metacritic;

        public Jogo(String titulo, int ano, String genero,
                    int maxJogadores, int metacritic)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
            this.metacritic = metacritic;
        }

        public Jogo(String titulo, int ano, String genero,
                    int maxJogadores)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
        }

     
        public String getTitulo()
        {
            return this.titulo;
        }

      
        public void setTitulo(String titulo)
        {
            if (titulo != "")
                this.titulo = titulo;
        }

        public int getAno()
        {
            return this.ano;
        }

        public int getmaxJogadores()
        {
            return this.maxJogadores;
        }
        
        public int getmetacritic()
        {
            return this.metacritic;
        }

    }
}