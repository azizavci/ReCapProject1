﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //sen bir IEntityRepository sin ve çalışma alanın Brand dır
    public interface ICarDAL:IEntityRepository<Car>
    {
        
    }
}
