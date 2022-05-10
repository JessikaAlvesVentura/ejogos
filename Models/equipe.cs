using ejogos.Interface;
using System.Collections.Generic;
using System.IO;

namespace ejogos.Models
{

    //: herança
    //, interface


    public class equipe : equipebase, IEquipe
    {
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        //variavel de dados

        private const string caminhobd = "Database/equipe.csv";

        public equipe()
        {
            CriarPastaOuArquivo(caminhobd);
        }

        //criar uma função que vai receber o obj equipe e vai retornar no formato de csv (string)

        private string Preparar(equipe e)
        {
            return e.IdEquipe + ";" + e.Nome + ";" + e.Imagem;

        }







        public void Criar(equipe novaequipe)
        {
            string[] equipe_texto = { Preparar(novaequipe) }; 

            File.AppendAllLines(caminhobd, equipe_texto);
        }

        public List<equipe> Lerequipes()
        {
            List<equipe> listaequipes = new List<equipe>();

            //ler todas as linhas do arquivo csv, armazenar em um array

            string [] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                //1; nome da equipe; caminho da imagem

                string[] linhaEquipe = item.Split(" ; ");
                equipe equipeatual = new equipe();
                equipeatual.IdEquipe = int.Parse(linhaEquipe[0]);
                equipeatual.Nome = linhaEquipe[1];
                equipeatual.Imagem = linhaEquipe[2];

                listaequipes.Add(equipeatual);
            }



            return listaequipes; 


        }
    }
}
