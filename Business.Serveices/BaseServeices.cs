using Business.Model;
using Data.BaseRepository;
using Data.Entity.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Serveices
{
    public class BaseServeices
    {
        public BaseServeices()
        {

        }

        public List<Team> GetTeams()
        {
            using (var UnitOfWork = (IUnitOfWork)(new UnitOfWork( new GvResourceContext())))
            {
                // return new List<Team>(UnitOfWork.Team.GetList());
                var lst = new List<Team>();
                lst = (List<Team>)UnitOfWork.Team.GetList();
                return lst;
            }
        }
    }
}
