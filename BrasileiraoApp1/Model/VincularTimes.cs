﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrasileiraoApp.Model
{
    public class VincularTimes
    {
        private int resIdTime;
        private string resTime;
    

        public string ResTime { get => resTime; set => resTime = value; }
        public int ResIdTime { get => resIdTime; set => resIdTime = value; }

        public List<VincularTimes> CarregarVinculados(int idCampeonato)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from timeCampeonato in context.TIME_CAMPEONATO
                            join time in context.TIME on timeCampeonato.idTime equals time.id
                            where timeCampeonato.idCampeonato == idCampeonato 
                            orderby time.nome 
                            select new VincularTimes
                            {
                                resIdTime = time.id,
                                resTime = time.nome
                            };

                return query.ToList();

            }
        }

        public List<VincularTimes> CarregarNaoVinculados(int idCampeonato)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                var query = from time in context.TIME
                            where !(
                                from timeCampeonato in context.TIME_CAMPEONATO
                                where timeCampeonato.idCampeonato == idCampeonato
                                select timeCampeonato.idTime).Contains(time.id)
                            orderby time.nome
                            select new VincularTimes
                            {
                                resIdTime = time.id,
                                resTime = time.nome
                            };

                return query.ToList();
            }
        }

        public void vincularTimeCampeonato(TIME_CAMPEONATO timeCampeonato)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                context.TIME_CAMPEONATO.Add(timeCampeonato);
                context.SaveChanges();
            }
        }

        public void desvincularTimeCampeonato(TIME_CAMPEONATO timeCampeonato)
        {
            using (CAMPEONATOSEntities context = new CAMPEONATOSEntities())
            {
                //var query = (from removeTimeCampeonato in context.TIME_CAMPEONATO
                //             where removeTimeCampeonato.idTime == timeCampeonato.idTime
                //                   && removeTimeCampeonato.idCampeonato == timeCampeonato.id
                //             select removeTimeCampeonato
                //           ).First();

                //Console.WriteLine("");

                //context.TIME_CAMPEONATO.Remove(query.First());
               // context.SaveChanges();
            }
        }
    }
}
