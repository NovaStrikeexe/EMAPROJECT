namespace EMAProject.Domain.Repositories.Abstract
{
    public interface ISettingsDB
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}