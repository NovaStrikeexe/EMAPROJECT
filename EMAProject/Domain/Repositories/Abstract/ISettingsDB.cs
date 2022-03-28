namespace EMAProject.Domain.Repositories.Abstract
{
    public interface ISettingsDB
        {
        string ServiceItemCollection {get;set;}
        string TextFieldCollection {get;set;}
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}