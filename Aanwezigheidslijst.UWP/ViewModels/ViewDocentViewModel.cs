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

        private DocentViewModel _selectedDocent;


        public readonly RelayCommand RemoveDocentCommand;

        public ViewDocentViewModel(ViewDocentModel model) : base(model)
        {
            _docenten = new ObservableCollection<DocentViewModel>();

            foreach (var item in model.ViewDocenten)
            {
                var docViewModel = new DocentViewModel(item);
                _docenten.Add(docViewModel);


                this.RemoveDocentCommand = new RelayCommand(() => DeleteDocent());
            }
            //ViewCommand = new RelayCommand(() => View());
        }

        private void MemberViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _selectedDocent = sender as DocentViewModel;
        }

        public DocentViewModel SelectedDocent
        {
            get => _selectedDocent;
            set => SetProperty(ref _selectedDocent, value);
        }

        public ObservableCollection<DocentViewModel> Docenten
        {
            get => _docenten;
            set => SetProperty(ref _docenten, value);
        }
        private void DeleteDocent()
        {
            try
            {
                Model.DeleteDocent(SelectedDocent.Id);
                Docenten.Remove(SelectedDocent);
            }
            catch (Exception)
            {

            }
            
        }


    }
}

