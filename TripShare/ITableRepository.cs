using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public interface ITableRepository
    {
        TableInfo GetInformationAboutTable();
    }
}
