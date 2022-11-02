﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}