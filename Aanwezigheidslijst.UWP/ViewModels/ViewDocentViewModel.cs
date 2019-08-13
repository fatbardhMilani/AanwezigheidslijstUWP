using Aanwezigheidslijst.EF.Model;
using Aanwezigheidslijst.UWP.Commands;
using Aanwezigheidslijst.UWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Aanwezigheidslijst.UWP.ViewModels
{
    public class ViewDocentViewModel : BaseViewModel<ViewDocentModel>
    {
        //public readonly ICommand ViewCommand;
        private ObservableCollection<DocentViewModel> _docenten;
         

        public ViewDocentViewModel(ViewDocentModel model) : base(model)
        {
            _docenten = new ObservableCollection<DocentViewModel>();

            foreach (var item in model.ViewDocenten)
            {
                var docViewModel = new DocentViewModel(item);
                _docenten.Add(docViewModel);
            }
            //ViewCommand = new RelayCommand(() => View());
        }

        public string Naam
        {
            get => Model.ViewDocenten.ToString();

        }

    }
}
