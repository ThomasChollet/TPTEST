using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public interface ILangue
    {
        abstract public string GetLanguage();

        abstract public string DireBonjour();

        abstract public string DireBonsoir();

        abstract public string Inviter();

        abstract public string BienDit();

        abstract public string MalDit();

        abstract public string AuRevoir();

    }
}
