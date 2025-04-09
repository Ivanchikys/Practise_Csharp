using System.ComponentModel;

namespace TeacherJournal.Models;

public class StudentGradeItem : INotifyPropertyChanged
{
    private string _fullName;
    private string _grade;
    private string _comment;
    private bool _isPresent;
    private double _average;

    public string FullName
    {
        get => _fullName;
        set
        {
            _fullName = value;
            OnPropertyChanged(nameof(FullName));
        }
    }

    public string Grade
    {
        get => _grade;
        set
        {
            _grade = value;
            OnPropertyChanged(nameof(Grade));
        }
    }

    public string Comment
    {
        get => _comment;
        set
        {
            _comment = value;
            OnPropertyChanged(nameof(Comment));
        }
    }

    public bool IsPresent
    {
        get => _isPresent;
        set
        {
            _isPresent = value;
            OnPropertyChanged(nameof(IsPresent));
        }
    }

    public double Average
    {
        get => _average;
        set
        {
            _average = value;
            OnPropertyChanged(nameof(Average));
        }
    }

    public string CourseName { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}