﻿using System;

namespace BancoRoxinho.Dominio.Model
{
    // Pessoa Juridica herda Pessoa
    public class PessoaJuridica : Pessoa
    {
        public string CPNJ { get; set; }
        public PessoaJuridica CadastrarPessoa()
        {
            throw new NotImplementedException();
        }
    }
}
