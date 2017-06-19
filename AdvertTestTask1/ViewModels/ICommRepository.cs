using System.Collections.Generic;

namespace AdvertTestTask1.ViewModels
{
    public interface ICommRepository
    {
        IEnumerable<Commission> GetAllCommissions();
    }
}