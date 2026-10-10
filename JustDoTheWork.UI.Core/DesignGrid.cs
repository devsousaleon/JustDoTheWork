using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace JustDoTheWork.UI.Core
{
    public static class DesignGrid
    {
        public static void Configurar(GridView grid, params (GridColumn coluna, int largura)[] colunas)
        {
            grid.OptionsView.ColumnAutoWidth = true;
            grid.OptionsView.ShowButtonMode = ShowButtonModeEnum.ShowAlways;
            grid.OptionsBehavior.EditorShowMode = EditorShowMode.MouseDown;
            grid.OptionsBehavior.Editable = grid.Columns.Cast<GridColumn>()
                .Any(coluna => coluna.ColumnEdit?.GetType() == typeof(RepositoryItemButtonEdit));

            foreach (var coluna in grid.Columns.Cast<GridColumn>())
            {
                // Editores de data também herdam de RepositoryItemButtonEdit.
                var colunaAcao = coluna.ColumnEdit?.GetType() == typeof(RepositoryItemButtonEdit);
                var colunaId = coluna.FieldName is "Id" or "AtividadeId";
                var colunaData = coluna.FieldName.StartsWith("Data", StringComparison.Ordinal);
                var colunaAtivo = coluna.FieldName == "Ativo";
                var alinhamento = colunaAcao || colunaId || colunaData || colunaAtivo
                    ? HorzAlignment.Center : HorzAlignment.Near;

                coluna.AppearanceHeader.Options.UseTextOptions = true;
                coluna.AppearanceHeader.TextOptions.HAlignment = alinhamento;
                coluna.AppearanceHeader.TextOptions.VAlignment = VertAlignment.Center;
                coluna.AppearanceCell.Options.UseTextOptions = true;
                coluna.AppearanceCell.TextOptions.HAlignment = alinhamento;
                coluna.AppearanceCell.TextOptions.VAlignment = VertAlignment.Center;
                coluna.OptionsColumn.AllowEdit = colunaAcao;
                coluna.OptionsColumn.ReadOnly = !colunaAcao;
                coluna.ShowButtonMode = colunaAcao
                    ? ShowButtonModeEnum.ShowAlways : ShowButtonModeEnum.ShowOnlyInEditor;
                coluna.MinWidth = colunaData ? 160 : 120;

                if (colunaData)
                {
                    coluna.DisplayFormat.FormatType = FormatType.DateTime;
                    coluna.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
                }

                if (colunaId || colunaAtivo)
                {
                    coluna.MinWidth = 55;
                    coluna.MaxWidth = 90;
                }

                if (colunaAcao)
                {
                    coluna.Caption = "Ação";
                    coluna.Fixed = FixedStyle.Right;
                    coluna.MinWidth = 70;
                    coluna.MaxWidth = 90;
                    coluna.Width = 80;
                    coluna.OptionsColumn.AllowSort = DefaultBoolean.False;
                }
            }

            foreach (var (coluna, largura) in colunas)
                coluna.Width = largura;
        }
    }
}
