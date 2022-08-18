namespace BehavioralPatterns;

internal class Student : IStudent
{
    private IStudentState _state;

    internal Student()
    {
        _state = new InfoEntered();
    }

    public void ChangeState(IStudentState state)
    {
        _state = state;
    }

    public void DelegateToState()
    {
        _state.Delegate();
    }
}