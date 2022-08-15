using SmtWallet.Web.Data.Entities;

namespace SmtWallet.Web.Data.Repositories.Interfaces
{
    public interface ILanguageRepository
    {
        Task<IEnumerable<Language>> Get(string filter);
        Task<Language> Get(int id);
        Task<int> Add(Language language);
        Task Update(Language language);
        Task Delete(int id);
    }

}