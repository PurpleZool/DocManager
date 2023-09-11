using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocManager.Enums
{
    public enum Response
    {
        UNHANDLED_ERROR = 0,
        OK,
        TITLE_ALREADY_PRESENT,
        HASH_ALREADY_PRESENT,
        DOCUMENT_CHANGED,
        NOT_PRESENT,

    }



}
