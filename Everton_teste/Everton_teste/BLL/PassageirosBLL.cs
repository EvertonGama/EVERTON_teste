using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Everton_teste.BLL
{
    public class PassageirosBLL
    {
        public List<Models.Passageiros_Grid> GetGrid()
        {
            Repositorio.Passageiros repository = new Repositorio.Passageiros();
            DataTable dt = repository.GetGrid();

            List<Models.Passageiros_Grid> _list = new List<Models.Passageiros_Grid>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Models.Passageiros_Grid item = new Models.Passageiros_Grid();
                item.Codigo = Convert.ToInt32(dt.Rows[i]["Id"].ToString());
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.CPF = dt.Rows[i]["CPF"].ToString();

                _list.Add(item);
            }

            return _list;
        }

        public void Salvar(Models.Passageiros_Novo novo)
        {
            Repositorio.Passageiros repository = new Repositorio.Passageiros();
            repository.Salvar(novo);
        }

        public List<Models.Corrida_Passageiros> GetSelect()
        {
            Repositorio.Passageiros repository = new Repositorio.Passageiros();

            var dt = repository.GetSelect();
            List<Models.Corrida_Passageiros> _list = new List<Models.Corrida_Passageiros>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Models.Corrida_Passageiros item = new Models.Corrida_Passageiros();
                item.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                item.Value = dt.Rows[i]["Nome"].ToString();

                _list.Add(item);
            }

            return _list;


        }
    }
}