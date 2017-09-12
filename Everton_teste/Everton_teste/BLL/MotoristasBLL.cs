using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Everton_teste.BLL
{
    public class MotoristasBLL
    {
        public List<Models.Motoristas_Grid> GetGrid()
        {
            Repositorio.Motoristas repository = new Repositorio.Motoristas();
            DataTable dt = repository.GetGrid();

            List<Models.Motoristas_Grid> _list = new List<Models.Motoristas_Grid>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Models.Motoristas_Grid item = new Models.Motoristas_Grid();
                item.Codigo = Convert.ToInt32(dt.Rows[i]["Id"].ToString());
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.CPF = dt.Rows[i]["CPF"].ToString();

                _list.Add(item);
            }

            return _list;
        }

        public void Salvar(Models.Motoristas_Novo novo)
        {
            Repositorio.Motoristas repository = new Repositorio.Motoristas();
            repository.Salvar(novo);
        }

        public List<Models.Corrida_Mototristas> GetSelect()
        {
            Repositorio.Motoristas repository = new Repositorio.Motoristas();

            var dt = repository.GetSelect();
            List<Models.Corrida_Mototristas> _list = new List<Models.Corrida_Mototristas>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Models.Corrida_Mototristas item = new Models.Corrida_Mototristas();
                item.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                item.Value = dt.Rows[i]["Nome"].ToString();

                _list.Add(item);
            }

            return _list;
        }
    }
}