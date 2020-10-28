using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace Ivan_Arsua.First_Quarterly_Assesment.Problems
{
    /// <summary>
    /// Interaction logic for ProblemsWindow.xaml
    /// </summary>
    public partial class ProblemsWindow : Window
    {
        public ProblemsWindow()
        {
            InitializeComponent();
            Problems problems = new Problems();
            using (StreamReader r = new StreamReader("Data\\json3.json"))
            {
                string json = r.ReadToEnd();
                problems = JsonConvert.DeserializeObject<Problems>(json);
                
            }
            lblProblems.Content = " Problems" + problems.problems;
            lblDiabetes.Content = " Diabetes" + problems.Diabetes;
            lblMedications.Content = "Medications" + problems.medications;
        }
    }
}
