using Library.Interfaces;
using Library.Model;
using System;
using System.ComponentModel;
using System.Windows;

namespace Library
{
    /// <summary>
    /// Interaction logic for AutorWindow.xaml
    /// </summary>
    public partial class AutorWindow : Window
    {
        private BindingList<Autor> autors;

        public IAutorService AutorService { get; }

        public AutorWindow(IAutorService autorService)
        {
            InitializeComponent();
            AutorService = autorService;
        }

        private void dgAutorList_Loaded(object sender, RoutedEventArgs e)
        {
            this.autors = this.AutorService.GetAutorList();

            dgAutorList.ItemsSource = this.autors;
            autors.ListChanged += Autors_ListChanged;
        }

        private void Autors_ListChanged(object? sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded ||
                e.ListChangedType == ListChangedType.ItemDeleted ||
                e.ListChangedType == ListChangedType.ItemChanged)
            {

            }
        }
    }
}