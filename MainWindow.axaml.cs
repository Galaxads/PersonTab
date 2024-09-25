using Avalonia.Controls;
using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using Works.Models;

namespace Works
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Listins(SavingDate.klient);
            FiltrPol.SelectedIndex = 0;
        }

        private void Listins(List<Клиенты> list)
        { int v = 0;
            bool d=false;
            ListPers.ItemsSource = list.Select(x => new
            {

                x.Id,
                x.Name,
                Gender = x.Gender == 1 ? "Мужчина" : "Женщина",
                x.Surname,
                x.MiddleName,
                x.Birthday,
                x.DateRegistr,
                x.NumberPhone,
                x.EmailAdress,
               // v = x.Id-1 <=SavingDate.posehs.Count-1 && x.Id-1 <= SavingDate.visits.Count - 1 ? SavingDate.visits[x.Id-1].DateVisit :  ,
               // dd = x.Id - 1 <= SavingDate.posehs.Count - 1 ? true : false,
                //Visit = dd==true ? SavingDate.visits[v].DateVisit :  ,
                x.ColvoVisit,
                //photo= new Bitmap ($"Assets/{x.Photo}")
                
            });
        }

        private void ComboBox_SelectionChanged(object? sender, Avalonia.Controls.SelectionChangedEventArgs e)
        {
            Filtrs();
        }
        private void Filtrs()
        {
            int v = FiltrPol.SelectedIndex;
            switch (v)
            {
                case 0:
                    Listins(SavingDate.klient); break;
                case 1: Listins(SavingDate.klient.Where(x => x.Gender == 1).ToList()); break;
                case 2: Listins(SavingDate.klient.Where(x => x.Gender == 2).ToList()); break;
            }
            int d = Filtr.SelectedIndex;
            switch (d)
            {
                case 1:
                    Listins(SavingDate.klient.OrderBy(x => x.MiddleName).ToList()); break;
                case 2:
                // Listins(SavingDate.klient.OrderByDescending(x => x.LastVisit).ToList());break;
                case 3:
                    //  return clients.OrderByDescending(x => x.VisitsLogs.Count).ToList();
                    break;
            }
        }
    }
}