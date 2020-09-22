using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public enum OrderStatus
    {
        SCHEMALAGD, //Operatör har lagt order i sitt schema.
        ACCEPTERAD, //Operatör har tagit emot och skall börja
        NEKAD, //Operatör har nekat arbetsorder
        EJ_ACCEPTERAD, //Operatör har inte "sett" arbetsordern
        KLAR, // Operatör har gjort klart order
        FAKTURA_SKICKAD // Admin har skickat faktura och order visas endast i history tabellen
    }
}
