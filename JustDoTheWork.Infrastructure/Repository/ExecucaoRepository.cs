using Dapper;
using DevExpress.XtraEditors;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace JustDoTheWork.Infrastructure.Repository
{
    internal class ExecucaoRepository : IExecucaoRepository
    {
        private readonly IDbConnection _connection;

        public ExecucaoRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public void Inclusao(Execucao execucao)
        {
            var sql = @"INSERT INTO execucao(datainicio, datafim, atividadeid) VALUES(@DataInicio, @DataFim, @AtividadeId)";

            using (var transaction = _connection.BeginTransaction())
            {
                try
                {
                    _connection.Execute(sql, execucao, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    XtraMessageBox.Show("Erro ao iniciar a execução! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Edicao(Execucao execucao)
        {
            throw new NotImplementedException();
        }
        public void ExclusaoPorId(int id)
        {
            throw new NotImplementedException();
        }
        public Execucao BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Execucao> Pesquisar(ExecucaoFiltro filtro)
        {
            throw new NotImplementedException();
        }
    }
}
