//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Erip.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_FULL
    {
        public System.Guid id_payments { get; set; }
        public string msgnum { get; set; }
        public string msgDT { get; set; }
        public string usluga { get; set; }
        public string lsnum { get; set; }
        public string fio { get; set; }
        public Nullable<decimal> paysum { get; set; }
        public string paydescr { get; set; }
        public string flg { get; set; }
        public Nullable<System.DateTime> dlast { get; set; }
        public Nullable<decimal> zachsum { get; set; }
        public string numoper { get; set; }
        public string nusl { get; set; }
        public string msgdate { get; set; }
    }
}
