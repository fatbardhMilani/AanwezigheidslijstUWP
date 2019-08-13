using Aanwezigheidslijst.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aanwezigheidslijst.ApplicationLogic.Contracts
{
    public static class ApplicationBootstrap
    {
        public static void Initialize()
        {
            using (var db = new AanwezigheidslijstDbContext()) // gebruik in app - app.xaml.cs om database te linken
            {
                db.Database.Migrate();
            }
        }
    }
}
