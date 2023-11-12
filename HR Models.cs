using SQLite;
public class HRModels
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string FullName { get; set; }
    public string JobTitle { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
    public string Address { get; set; }
}
