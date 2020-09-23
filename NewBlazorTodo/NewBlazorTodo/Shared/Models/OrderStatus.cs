using System;
using System.Collections.Generic;
using System.Text;

namespace NewBlazorTodo.Shared.Models
{
    public enum OrderStatus
    {
        EJ_ACCEPTERAD, // (0) Operatör har inte "sett" arbetsordern
        ACCEPTERAD, // (1) Operatör har accepterat ordern
        NEKAD, // (2) Operatör har nekat ordern
        KLAR, // (3) Operatör har gjort klart order
        FAKTURA_SKICKAD // (4) Admin har skickat faktura och order visas endast i history tabellen
    }
}
