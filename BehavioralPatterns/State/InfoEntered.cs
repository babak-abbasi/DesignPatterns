namespace BehavioralPatterns;

internal class InfoEntered : IStudentState
{
    private IStudent _student;

    void IStudentState.Delegate()
    {
        //Do something 
        _student.ChangeState(new Registered());
    }
}