//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrasileiraoApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class JOGO
    {
        public int id { get; set; }
        public int idRodada { get; set; }
        public int idCampeonato { get; set; }
        public int idTimeCasa { get; set; }
        public int golsCasa { get; set; }
        public int numeroFaltasCasa { get; set; }
        public int idTimeVisitante { get; set; }
        public int golsVisitante { get; set; }
        public int numeroFaltasVisitante { get; set; }
        public string observacaoJogo { get; set; }
    
        public virtual CAMPEONATO CAMPEONATO { get; set; }
        public virtual RODADA RODADA { get; set; }
        public virtual TIME TIME { get; set; }
        public virtual TIME TIME1 { get; set; }
    }
}
