using Aanwezigheidslijst.ApplicationLogic;
using Aanwezigheidslijst.ApplicationLogic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aanwezigheidslijst.UWP.Models
{
    public class ViewDocentModel
    {
        private readonly DocentService _docentService = new DocentService();
        public readonly ICollection<ViewDocent> ViewDocenten;

        public ViewDocentModel()
        {
            ViewDocenten = _docentService.Read();
        }

    }
}
