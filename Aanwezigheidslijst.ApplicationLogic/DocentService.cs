﻿using Aanwezigheidslijst.ApplicationLogic.Contracts;
using Aanwezigheidslijst.EF;
using Aanwezigheidslijst.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aanwezigheidslijst.ApplicationLogic
{
    public class DocentService
    {
        public void Create(CreateDocent docent)
        {
            using (var ctx = new AanwezigheidslijstDbContext())
            {
                ctx.Add(new Docent()
                {
                    Bedrijf = docent.Bedrijf,
                    Naam = docent.Naam
                });

                ctx.SaveChanges();
            }
        }

        public List<ViewDocent> Read()
        {
            using (var ctx = new AanwezigheidslijstDbContext())
            {
                return ctx.Docenten.Select(
                    d => new ViewDocent()
                    {
                        Id = d.Id,
                        Naam = d.Naam,
                        Bedrijf = d.Bedrijf
                    }).ToList();
            }
        }

        public void Delete(DeleteDocent docent)
        {
            string vrwdrDoc = docent.ToString();

            using (var ctx = new AanwezigheidslijstDbContext())
            {
                var doc = ctx.Docenten.SingleOrDefault(d => d.Naam == vrwdrDoc);
                ctx.Docenten.Remove(doc);
            }
        }

    }
}
