using Dapper;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System.Text;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ModeloRelatorioRepository : IModeloRelatorioRepository
    {
        private readonly DBConnection _dbConnection;

        public ModeloRelatorioRepository(DBConnection _dbConnection)
        {
            this._dbConnection = _dbConnection;
        }
        public string Inclusao(ModeloRelatorio projeto)
        {
            var sql = "INSERT INTO ModeloRelatorio (descricao, tipomodeloid, texto, ativo) VALUES(@Descricao, @TipoModeloId, @Texto, @Ativo)";

            using (var connection =  _dbConnection.Create())
            {
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, projeto, transaction);
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return "Erro ao incluir o modelo! \n" + ex.Message;
                        }
                    }
                }
                catch (Exception exception)
                {
                    return "Erro de conexão com banco de dados. " + exception.Message;
                }
                finally
                {
                    connection.Dispose();
                }
            }
            return "";
        }

        public string Edicao(ModeloRelatorio projeto)
        {
            var sql = "UPDATE ModeloRelatorio SET Descricao = @Descricao, TipoModeloId = @TipoModeloId, Texto = @Texto, Ativo = @Ativo where Id = @Id";

            using (var connection = _dbConnection.Create())
            {
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, projeto, transaction);
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return "Erro ao editar o modelo! \n" + ex.Message;
                        }
                    }
                }
                catch (Exception exception)
                {
                    return "Erro de conexão com banco de dados. " + exception.Message;
                }
                finally
                {
                    connection.Dispose();
                }
            }

            return "";
        }

        public string ExclusaoPorId(int Id)
        {
            var sql = "DELETE FROM ModeloRelatorio where Id = @Id";

            using (var connection = _dbConnection.Create())
            {
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, new { id = Id }, transaction);
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return "Erro ao excluir o modelo! \n" + ex.Message;
                        }
                    }
                }
                catch (Exception exception)
                {
                    return "Erro de conexão com banco de dados. " + exception.Message;
                }
                finally
                {
                    connection.Dispose();
                }
            }

            return "";
        }

        public ModeloRelatorioDTO BuscarPorId(int id)
        {
            var sql = @"SELECT * FROM modelorelatorio WHERE id = @Id";

            using var connection = _dbConnection.Create();
                return connection.QueryFirstOrDefault<ModeloRelatorioDTO>(sql, new { Id = id });
        }

        public byte[]? BuscaModeloHistoricoExecucao()
        {
            var sql = @"SELECT Texto FROM ModeloRelatorio WHERE TipoModeloId = 1 AND Ativo = 1";

            using var connection = _dbConnection.Create();
                return connection.QueryFirstOrDefault<byte[]>(sql);
        }

        public IEnumerable<ResultadoPesquisaModeloRelatorioDTO> Pesquisar(FiltroPesquisaModeloRelatorioDTO filtroPesquisaModeloRelatorioDTO)
        {
            var sql = new StringBuilder();
            var parametros = new DynamicParameters();

            sql.Append(@"SELECT
                            mr.Id, mr.Descricao,
                            tm.Descricao AS TipoModelo, mr.Ativo
                            FROM ModeloRelatorio mr
                            INNER JOIN TipoModelo tm ON tm.Id = mr.TipoModeloId
                            WHERE 1 = 1");

            if (!string.IsNullOrEmpty(filtroPesquisaModeloRelatorioDTO.DescricaoModelo))
            {
                sql.Append(" AND mr.Descricao LIKE @DescricaoModelo");
                parametros.Add("@DescricaoModelo", filtroPesquisaModeloRelatorioDTO.DescricaoModelo.Trim());
            }

            if (filtroPesquisaModeloRelatorioDTO.TipoModelo > 0)
            {
                sql.Append(" AND mr.TipoModeloId = @TipoModelo");
                parametros.Add("@TipoModelo", filtroPesquisaModeloRelatorioDTO.TipoModelo);
            }

            using var connection = _dbConnection.Create();
                return connection.Query<ResultadoPesquisaModeloRelatorioDTO>(sql.ToString(), parametros);
        }
    }
}