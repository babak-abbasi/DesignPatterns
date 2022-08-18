namespace BehavioralPatterns;

internal class Expelled : IStudentState
{
    private IStudent _student;

    void IStudentState.Delegate()
    {
        //Do something 
    }
}