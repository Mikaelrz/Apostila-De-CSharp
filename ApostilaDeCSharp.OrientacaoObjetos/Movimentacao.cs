using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ApostilaDeCSharp.OrientacaoObjetos
{
    public class Movimentacao
    {
        public string Voar(Personagem p)
        {
            if (p.QtdePontos > 10)
            {
                return $"{p.Nome} voou";
            }
            else
            {
                return $"{p.Nome} não voou";
            }

        }
        public string Nadar(Personagem p)
        {
            return $"{p.Nome} nadou";

        }
        public string Pular(Personagem p)
        {
            return $"{p.Nome} pulou";

        }
        public string Correr(Personagem p)
        {
            return $"{p.Nome} correu!";
        }
        public string VirarEsquerda(Personagem p)
        {
            return $"{p.Nome} virou a esquerda";
        }
        public string VirarDireita(Personagem p)
        {
            return $"{p.Nome} virou a direita";
        }
        public string Parar(Personagem p)
        {
            SoundPlayer player = new SoundPlayer();
            player.Play();
            return $"{p.Nome} parou";
        }
        public string Andar(Personagem p)
        {
            return $"{p.Nome} andou";
        }
        public string Voltar(Personagem p)
        {
            return $"{p.Nome} voltou!";
        }

    }
}


