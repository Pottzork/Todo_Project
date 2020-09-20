using System;
using System.Collections.Generic;
using System.Text;

namespace NewBlazorTodo.Shared.Models
{
    public enum OrderStatus
    {
        SCHEMALAGD, //Operatör har lagt order i sitt schema.
        ACCEPTERAD, //Operatör har tagit emot och skall börja
        NEKAD, //Operatör har nekat arbetsorder
        EJ_ACCEPTERAD, //Operatör har inte "sett" arbetsordern
        KLAR, // Operatör har gjort klart order
        BETALD // Admin har betalat och order visas endast i history tabellen
    }
}
