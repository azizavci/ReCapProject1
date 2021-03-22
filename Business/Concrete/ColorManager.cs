using Business.Abstract;
using Business.Constants.NorthwindConstants;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using Core.Utilities.Results;
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

        public IResult Add(Color color)
        {
            ValidationTool.Validate(new ColorValidator(), color);
            _colorDAL.Add(color);
            return new Result(true, Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);
            }
            _colorDAL.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDAL.GetAll(),Messages.ColorsListed);
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDAL.Get(c => c.Id == colorId));
        
        }

        public IResult Update(Color color)
        {
            _colorDAL.Update(color);
            return new Result(true, Messages.ColorUpdated);
        }
    }
}
