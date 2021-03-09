using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDAL _colorDAL;

        public ColorManager(IColorDAL colorDAL)
        {
            _colorDAL = colorDAL;
        }

        public void Add(Color color)
        {
            _colorDAL.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDAL.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDAL.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDAL.Get(c => c.Id == colorId);
        
        }

        public void Update(Color color)
        {
            _colorDAL.Update(color);
        }
    }
}
