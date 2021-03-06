﻿using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Domain.Servicos;

namespace CTPSYSTEM.Application
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaStorage empresaContext;
        private readonly IEmpresaReadOnlyStorage empresaReadOnlyContext;

        public EmpresaService(IEmpresaStorage empresaContext, IEmpresaReadOnlyStorage empresaReadOnlyContext)
        {
            this.empresaContext = empresaContext;
            this.empresaReadOnlyContext = empresaReadOnlyContext;
        }

        public void Cadastrar(ContratoTrabalho contratoTrabalho)
        {
            this.empresaContext.Insert(contratoTrabalho);
            this.empresaContext.SaveChanges();
        }

        public void Cadastrar(AlteracaoSalarial alteracaoSalarial)
        {
            this.empresaContext.Insert(alteracaoSalarial);
            this.empresaContext.SaveChanges();
        }

        public void Cadastrar(ContribuicaoSindical contribuicaoSindical)
        {
            this.empresaContext.Insert(contribuicaoSindical);
            this.empresaContext.SaveChanges();
        }

        public void Cadastrar(AnotacaoGeral anotacaoGeral)
        {
            this.empresaContext.Insert(anotacaoGeral);
            this.empresaContext.SaveChanges();
        }

        public void Cadastrar(Ferias ferias)
        {
            this.empresaContext.Insert(ferias);
            this.empresaContext.SaveChanges();
        }

        public void Cadastrar(Licenca licenca)
        {
            this.empresaContext.Insert(licenca);
            this.empresaContext.SaveChanges();
        }

        public void Cadastrar(Internacao internacao)
        {
            this.empresaContext.Insert(internacao);
            this.empresaContext.SaveChanges();
        }

        public void DesvincularFuncionario(int idFuncionario)
        {
            var funcionario = this.empresaReadOnlyContext.RecuperaFuncionario(idFuncionario);
            funcionario.IdEmpresa = null;

            this.empresaContext.SaveChanges();
        }

        public void VincularFuncionario(int idFuncionario, int idEmpresa)
        {
            var funcionario = this.empresaReadOnlyContext.RecuperaFuncionario(idFuncionario);
            funcionario.IdEmpresa = idEmpresa;

            this.empresaContext.SaveChanges();
        }
    }
}