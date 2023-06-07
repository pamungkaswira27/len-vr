using UnityEngine;

[CreateAssetMenu(fileName = "Question", menuName = "Len VR/Question")]
public class QuestionSO : ScriptableObject
{
    [Header("Question Data")]
    [SerializeField] string _question;
    [SerializeField] QuestionAnswer[] _answers;

    public string GetQuestion()
    {
        return _question;
    }

    public QuestionAnswer GetAnswer(int index)
    {
        return _answers[index];
    }
}
