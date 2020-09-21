using System;
using System.Collections.Generic;
using System.Text;

namespace NewBlazorTodo.Shared.Models
{
    public enum OrderStatus
    {
        SCHEMALAGD, // (0) Operatör har lagt order i sitt schema. 
        ACCEPTERAD, // (1) Operatör har tagit emot och skall börja 
        NEKAD, // (2) Operatör har nekat arbetsorder
        EJ_ACCEPTERAD, // (3) Operatör har inte "sett" arbetsordern
        KLAR, // (4) Operatör har gjort klart order
        BETALD // (5) Admin har betalat och order visas endast i history tabellen
    }
}
