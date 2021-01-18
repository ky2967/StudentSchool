using LibController;
using LibModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentSchool.LibView
{
    /// <summary>
    /// ucView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ucView : UserControl
    {
        public List<Student> _cStudentList;

        public ucView()
        {
            InitializeComponent();
            cnDataSave cData = new cnDataSave();
            _cStudentList = cData._cStudentList;
        }

        private void txbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string sText = (sender as TextBox).Text;

            List<Student> cSearchedStudentList = _cStudentList.Where(item => item.Name.Contains(sText)).ToList();
            if (cSearchedStudentList.Count == 0 || sText == "")
            {
                lsbSearch.ItemsSource = null;
                return;
            }

            lsbSearch.ItemsSource = cSearchedStudentList.Select(item => item.Name);
        }

        private void lsbSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lsbSearch.SelectedItem == null)
            {
                SchoolGrid.DataContext = null;
                return;
            }

            string name = lsbSearch.SelectedItem as string;
            SchoolGrid.DataContext = _cStudentList.SingleOrDefault(item => item.Name == name).school;
        }
    }
}
