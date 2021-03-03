using Business.Model;
using Data.BaseRepository;
using Data.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

                var lst = UnitOfWork.Queryable<Team>().Where(s => s.Id == 1).ToList();
                return lst;
            }
        }
    }
}
