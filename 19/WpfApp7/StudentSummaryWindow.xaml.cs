using System.Collections.ObjectModel;
using System.Windows;
using TeacherJournal.Models;

namespace TeacherJournal;

public partial class StudentSummaryWindow : Window
{
    public StudentSummaryWindow(Enrollment selectedEnrollment, ObservableCollection<Enrollment> allStudents)
    {
        InitializeComponent();

        var studentGrades = allStudents
            .Where(s => s.Student.FullName == selectedEnrollment.Student.FullName)
            .ToList();

        var viewModel = new
        {
            FullName = selectedEnrollment.Student.FullName,
            Grades = selectedEnrollment.Grades,
            Average = selectedEnrollment.Grades.Average(se => int.Parse(se.Grade)),
        };

        DataContext = viewModel;
    }
}