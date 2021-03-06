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
    
    public partial class RODADA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RODADA()
        {
            this.JOGO = new HashSet<JOGO>();
            this.RESULTADO = new HashSet<RESULTADO>();
        }

        public RODADA(int idCampeonato, int numeroRodada, DateTime? dataRodada)
        {
            this.idCampeonato = idCampeonato;
            this.numeroRodada = numeroRodada;
            this.dataRodada = dataRodada;
        }

        public int id { get; set; }
        public int idCampeonato { get; set; }
        public int numeroRodada { get; set; }
        public Nullable<System.DateTime> dataRodada { get; set; }
    
        public virtual CAMPEONATO CAMPEONATO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOGO> JOGO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESULTADO> RESULTADO { get; set; }
    }
}
