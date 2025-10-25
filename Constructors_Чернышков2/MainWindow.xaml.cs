using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Constructors_Чернышков2
{
 
    public partial class MainWindow : Window
    {
        public List<Classes.Student> AllStudent = Classes.RepoStudents.AllStudent();
        public int Count = 10;
        public int Step = 0;

        public MainWindow()
        {
            InitializeComponent();
            CreateStudent(Step, Count);
        }

        public void CreateStudent(int Step, int Count)
        {
            for (int iStudent = Step; iStudent < Step + Count; iStudent++)
                if (AllStudent.Count > iStudent)
                    parent.Children.Add(new Elements.Student(AllStudent[iStudent]));
            this.Step += Count;
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scroll = sender as ScrollViewer;
            double ParentHeight = parent.ActualHeight;
            double WindowHeight = scroll.ActualHeight - 20;
            double DeltaHeight = ParentHeight - WindowHeight;
            if (DeltaHeight - scroll.VerticalOffset < 140)
            {
                CreateStudent(Step, Count);
            }
        }

        private void knopkaSohr_Click(object sender, EventArgs e) 
        {
            string Json = System.Text.Json.JsonSerializer.Serialize(AllStudent);
            System.IO.File.WriteAllText("студенты.Json", Json);
            
        
        }
    }
}