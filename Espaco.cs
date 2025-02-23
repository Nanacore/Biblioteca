﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    [Serializable]
    class Espaco
    {
        private string designacao;
        private int maxpessoas;
        private string abertura;
        private string encerramento;
        private string adicionais;

        public string Designacao { get => designacao; set => designacao = value; }
        public int MaxPessoas { get => maxpessoas; set => maxpessoas = value; }
        public string Abertura { get => abertura; set => abertura = value; }
        public string Encerramento { get => encerramento; set => encerramento = value; }
        public string Adicionais { get => adicionais; set => adicionais = value; }

        public Espaco(string designacao, int max, string abertura, string encerramento, string adicionais)
        {
            this.designacao = designacao;
            this.maxpessoas = max;
            this.abertura = abertura;
            this.encerramento = encerramento;
            this.adicionais = adicionais;
        }
        public Espaco(string designacao, string abertura, string encerramento, string adicionais)
        {
            this.designacao = designacao;
            this.abertura = abertura;
            this.encerramento = encerramento;
            this.adicionais = adicionais;
        }

        public Espaco(string designacao)
        {
            this.designacao = designacao;
        }

        public override string ToString()
        {
            string comentario;

            if (Adicionais != "")
            {
                comentario = "Possui 1 comentário";

            }
            else
            {
                comentario = "Possui 0 comentários";
            }

            return string.Format(" {0,-30}         ({1} - {2})         {3,20}", Designacao.ToUpper(), abertura, encerramento, comentario);
        }
    }
}
