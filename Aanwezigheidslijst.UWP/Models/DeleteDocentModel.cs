using Aanwezigheidslijst.ApplicationLogic;
using Aanwezigheidslijst.ApplicationLogic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aanwezigheidslijst.UWP.Models
{
    public class DeleteDocentModel
    {
        private readonly DocentService _docentService = new DocentService();
        public readonly DeleteDocent Docent = new DeleteDocent();

        public void DeleteDocent()
        {
            _docentService.Delete(Docent);
        }
    }
}
