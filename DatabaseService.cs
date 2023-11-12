using Part_3_HRApp_ROI;
using SQLite;
public class DatabaseService
{
    SQLiteAsyncConnection _database;
    public DatabaseService()
    {
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HRDepartment.db");
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<HRModels>().Wait();
    }

    public async Task AddhremployeeAsync(HRModels hremployee)
    { 
        await _database.InsertAsync(hremployee);
    }

    public async Task<List<HRModels>> Gethremployee()
    {
        return await _database.Table<HRModels>().ToListAsync();
    }
    public async Task UpdatehremployeeAsync(HRModels hremployee)
    {
        await _database.UpdateAsync(hremployee);
    }
    public async Task DeletehremployeeAsync(HRModels hremployee)
    {
        await _database.DeleteAsync(hremployee);
    }

}