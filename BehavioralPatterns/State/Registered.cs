namespace BehavioralPatterns;

internal class Registered : IStudentState
{
    private IStudent _student;

    void IStudentState.Delegate()
    {
        //Do something 
        _student.ChangeState(new Expelled());
    }
}