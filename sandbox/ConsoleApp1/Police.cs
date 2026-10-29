using System.Runtime.InteropServices;

class Police: Person
{
    private string _tools;
    public Police(string firstName, string lastName, int age, double weight, string tools)
    : base(firstName, lastName, age, weight)
    {
        _tools = tools;
    }

    public string GetPoliceInformation()
    {
        return $"Tools: {_tools}: {GetPersonInformation()}";
    }
}