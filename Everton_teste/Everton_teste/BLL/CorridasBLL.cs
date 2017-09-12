using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Everton_teste.BLL
{
    public class CorridasBLL
    {
        public void Salvar(Models.Corrida_Novo_Salvar novo)
        {
            Repositorio.Corrida repository = new Repositorio.Corrida();
            repository.Salvar(novo);
        }


        public List<Models.Corrida_Grid> GetGrid()
        {
            Repositorio.Corrida repository = new Repositorio.Corrida();
            DataTable dt = repository.GetGrid();

            List<Models.Corrida_Grid> _list = new List<Models.Corrida_Grid>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Models.Corrida_Grid item = new Models.Corrida_Grid();
                item.Codigo = Convert.ToInt32(dt.Rows[i]["Id"].ToString());
                item.Motorista = dt.Rows[i]["Motorista"].ToString();
                item.Passageiro = dt.Rows[i]["Passageiro"].ToString();
                item.Valor = Convert.ToDecimal(dt.Rows[i]["Valor"].ToString());

                _list.Add(item);
            }

            return _list;
        }

    }
}