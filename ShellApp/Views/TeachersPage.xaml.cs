using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellApp.Views
{
  public class Teacher
  {
    public string Degree { get; set; }
    public string Name { get; set; }
  }

  public partial class TeachersPage : ContentPage
  {
    public static ObservableCollection<Teacher> TeachersList { get; set; }

    public TeachersPage()
    {
      InitializeComponent();

      TeachersList = new ObservableCollection<Teacher>(
        new Teacher[]
        {
          new Teacher { Degree = "Ing.", Name = "Radko Sáblík" },
          new Teacher { Degree = "Mgr.", Name = "Zdeněk Nechanický" },
          new Teacher { Degree = "Ing.", Name = "Pavel Švec" }
        });

      TeachersLV.ItemsSource = TeachersList;
    }

    private void AddTeacherBut_Clicked(object sender, EventArgs e)
      => TeachersList.Add(new Teacher { Degree = "Mgr.", Name = "Tomáš Tkáč" });
  }
}