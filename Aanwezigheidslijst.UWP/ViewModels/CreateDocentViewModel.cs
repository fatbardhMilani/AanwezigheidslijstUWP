using Aanwezigheidslijst.UWP.Commands;
using Aanwezigheidslijst.UWP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Aanwezigheidslijst.UWP.ViewModels
{
    public class CreateDocentViewModel : BaseViewModel<CreateDocentModel>
    {
        public readonly ICommand SaveCommand;

        public CreateDocentViewModel() : base(new CreateDocentModel())
        {
            SaveCommand = new RelayCommand(() => Save());
        }

        private void Save()
        {
            Model.CreateDocent();
        }
        //sgsg
        public string Naam
        {
            get => Model.Docent.Naam;
            set => SetProperty(Model.Docent.Naam, value, () => Model.Docent.Naam = value);
            
        }

        public string Bedrijf
        {
            get => Model.Docent.Bedrijf;
            set => SetProperty(Model.Docent.Bedrijf, value, () => Model.Docent.Bedrijf = value);

        }
    }
}
