namespace BehavioralPatterns;

public interface IStudent
{
    void ChangeState(IStudentState state);
    void DelegateToState();
}