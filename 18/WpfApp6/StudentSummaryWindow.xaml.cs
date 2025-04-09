using System.Collections.ObjectModel;
using System.Windows;
using TeacherJournal.Models;

namespace TeacherJournal;

public partial class StudentSummaryWindow : Window
{
    public StudentSummaryWindow(StudentGradeItem selectedStudent, ObservableCollection<StudentGradeItem> allStudents)
    {
        InitializeComponent();
        
        var studentGrades = allStudents
            .Where(s => s.FullName == selectedStudent.FullName)
            .ToList();
        
        var viewModel = new
        {
            FullName = selectedStudent.FullName,
            Grades = studentGrades,
            Average = selectedStudent.Average
        };

        DataContext = viewModel;
    }
}