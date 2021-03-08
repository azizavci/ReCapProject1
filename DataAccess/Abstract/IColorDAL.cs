using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //sen bir IEntityRepository sin ve çalışma alanın Color dır
    public interface IColorDAL:IEntityRepository<Color>
    {
        
    }
}

