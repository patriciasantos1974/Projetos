using DataAccess;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class PessoaBussiness
    {
        public void Salvar (Pessoa pessoa)
        {
            var pessoaDA = new PessoaDataAccess();
            // Validação
            if (pessoa.IDPessoa<=0)
            {
                pessoaDA.InserirPessoa(pessoa);
            }
            else
            {
                pessoaDA.AlterarPessoa(pessoa);
            }
        }

        public Pessoa SelecionarPessoaPorId(int idpessoa)
        {
            var pessoaDA = new PessoaDataAccess();

            return pessoaDA.SelecionarPessoaPorId(idpessoa);
        }
    }
}
