using Dapper;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly DBConnectionFactory _factory;

        public ProjetoRepository(DBConnectionFactory factory)
        {
            _factory = factory;
        }

        public string Inclusao(Projeto projeto)
        {
            var sql = @"INSERT INTO projeto(nome) VALUES(@Nome)";
            try
            {
                using (var connection = _factory.Create())
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, projeto, transaction);
                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            return "Erro ao incluir projeto!";
                        }
                    }
                }
            }
            catch (Exception)
            {
                return "Erro ao conectar com o banco de dados!";
            }
            
            return "";
        }
        public string Edicao(Projeto projeto)
        {
            var sql = @"UPDATE projeto SET nome = @nome WHERE id = @Id";
            try
            {
                using (var connection = _factory.Create())
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, projeto, transaction);
                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            return "Erro ao editar dados do projeto!";
                        }
                    }
                }
            }
            catch 
            {
                return "Erro ao conectar com o banco de dados!";
            }
            return "";
        }
        public string ExclusaoPorId(int id)
        {
            var sql = @"DELETE FROM projeto WHERE id = @Id";

            try
            {
                using (var connection = _factory.Create())
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, new { Id = id }, transaction);
                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            return "Erro ao excluir projeto!";
                        }
                    }
                }
            }
            catch (Exception)
            {
                return "Erro ao conectar com o banco de dados!";
            }
            return "";
        }
        public Projeto BuscarPorId(int id)
        {
            var sql = @"SELECT * FROM projeto WHERE id = @Id";

            using (var connection = _factory.Create())
            {
                return connection.QueryFirstOrDefault<Projeto>(
                    sql,
                    new { Id = id }
                );
            }
        }
        public IEnumerable<Projeto> Pesquisar(ProjetoFilter filtro)
        {
            var sql = new StringBuilder();
            sql.Append("SELECT * FROM projeto WHERE 1 = 1 ");

            var parametros = new DynamicParameters();

            if (!string.IsNullOrWhiteSpace(filtro.Nome))
            {
                sql.Append("AND nome ILIKE @Nome ");
                parametros.Add("Nome", $"%{filtro.Nome}%");
            }

            using (var conn = _factory.Create())
            {
                return conn.Query<Projeto>(
                    sql.ToString(),
                    parametros
                );
            }
        }
    }
}
