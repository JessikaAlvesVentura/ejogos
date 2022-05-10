using System.IO;

namespace ejogos.Models
{
    public class equipebase
    {
        public void CriarPastaOuArquivo (string caminho)
        {
            string pasta = caminho.Split('/')[0];

            if (!Directory.Exists(pasta))
            {

                Directory.CreateDirectory(pasta);

            }

            if (!File.Exists(caminho))
            {

                File.Create(caminho);

            }
    }
}
