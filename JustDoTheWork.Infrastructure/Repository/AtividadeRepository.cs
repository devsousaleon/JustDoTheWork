using Dapper;
using DevExpress.XtraEditors;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;

        public AtividadeRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }
        public void Inclusao(Atividade atividade)
        {
            var sql = @"
            INSERT INTO Atividade (nome, descricao, status, datacriacao, datafinalizacao, projetoid)
            VALUES (@Nome, @Descricao, @Status, @DataCriacao, @DataFinalizacao, @ProjetoId);";

            using (var transaction = _connection.BeginTransaction())
            {
                try
                {
                    _connection.Execute(sql, atividade, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    XtraMessageBox.Show("Ocorreu um erro ao realizar a inclusão desta atividade! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Edicao(Atividade atividade)
        {
            var sql = @"UPDATE ATIVIDADE SET nome = @Nome, descricao = @Descricao, status = @Status,
                      datafinalizacao = @DataFinalizacao, projetoid = @ProjetoId where id = @Id";

            using (var transaction = _connection.BeginTransaction())
            {
                try
                {
                    _connection.Execute(sql, atividade, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    XtraMessageBox.Show("Ocorreu um erro ao realizar a edição desta atividade! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ExclusaoPorId(int id)
        {
            var sql = @"DELETE FROM atividade where id = @Id";

            using (var transaction = _connection.BeginTransaction())
            {
                try
                {
                    _connection.Execute(sql, id, transaction);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    XtraMessageBox.Show("Ocorreu um erro ao excluir desta atividade! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Atividade BuscarPorId(int id)
        {
            var sql = @"SELECT * FROM atividade WHERE id = @Id";

            return _connection.QueryFirstOrDefault<Atividade>(sql, new { Id = id }, _transaction);
        }      

        public IEnumerable<Atividade> Pesquisar(AtividadeFiltro filtro)
        {
            var sql = new StringBuilder();
            sql.Append("SELECT * FROM atividade WHERE 1 = 1 ");

            var parametros = new DynamicParameters();

            if (!string.IsNullOrWhiteSpace(filtro.Nome))
            {
                sql.Append("AND nome ILIKE @Nome ");
                parametros.Add("Nome", $"%{filtro.Nome}%");
            }

            if (filtro.Status > 0)
            {
                sql.Append("AND status = @Status ");
                parametros.Add("Status", filtro.Status);
            }

            if (filtro.ProjetoId > 0)
            {
                sql.Append("AND projetoid = @ProjetoId ");
                parametros.Add("ProjetoId", filtro.ProjetoId);
            }

            if (filtro.DataCriacao != default)
            {
                sql.Append("AND datacriacao::date = @DataCriacao ");
                parametros.Add("DataCriacao", filtro.DataCriacao.Value.Date);
            }

            if (filtro.DataFinalizacao.HasValue)
            {
                sql.Append("AND datafinalizacao::date = @DataFinalizacao ");
                parametros.Add("DataFinalizacao", filtro.DataFinalizacao.Value.Date);
            }

            return _connection.Query<Atividade>(
                sql.ToString(),
                parametros,
                _transaction
            );
        }
    }
}
