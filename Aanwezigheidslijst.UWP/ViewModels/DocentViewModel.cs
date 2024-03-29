﻿using Aanwezigheidslijst.ApplicationLogic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aanwezigheidslijst.UWP.ViewModels
{
    public class DocentViewModel : BaseViewModel<ViewDocent> /// maken nieuw model aan voor 1 docent op te vragen (nodige voor de rest(zie of UWPMVVM)
    {
        public DocentViewModel(ViewDocent model) : base(model)
        {

        }
        public int Id
        {   get => Model.Id;
            set => SetProperty(Model.Id, value, () => Model.Id = value);
        }
        
        public string Naam
        {
            get => Model.Naam;
            set
            {
                SetProperty(Model.Naam, value, () => { Model.Naam = value; RaisePropertyChanged(nameof(Naam)); });
            }
        }

        

        public string Bedrijf
        {
            get => Model.Bedrijf;
            set
            {
                SetProperty(Model.Bedrijf, value, () => { Model.Bedrijf = value; RaisePropertyChanged(nameof(Bedrijf)); });
            }
        }

        
    }
}
