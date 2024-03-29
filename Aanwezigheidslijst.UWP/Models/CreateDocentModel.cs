﻿using Aanwezigheidslijst.ApplicationLogic;
using Aanwezigheidslijst.ApplicationLogic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aanwezigheidslijst.UWP.Models
{
    public class CreateDocentModel
    {
        private readonly DocentService _docentService = new DocentService();
        public readonly CreateDocent Docent = new CreateDocent();

        public void CreateDocent()
        {
            _docentService.Create(Docent);
        }
    }
}
