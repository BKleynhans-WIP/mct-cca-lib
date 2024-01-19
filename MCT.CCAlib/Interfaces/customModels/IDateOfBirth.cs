namespace MCT.CCAlib.Interfaces.customModels
{
    public interface IDateOfBirth
    {
        short Day { get; set; }
        short Month { get; set; }
        short Year { get; set; }
        string DateOfBirthString { get; }
    }
}