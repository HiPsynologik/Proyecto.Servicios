using System;
using System.Collections.Generic;
using Proyecto.Servicios.Shared.Models;
using Proyecto.Servicios.Shared.ModelService;
using Error = Proyecto.Servicios.Shared.Resources.EmptyRequest;

namespace Proyecto.Servicios.Shared.Controllers
{
    public abstract class ControllerBase : IDisposable
    {
        public abstract List<ErrorMessage> ValidateOperationRequest<TOperationRequest, TModel>(TOperationRequest request) where TOperationRequest : OperationRequestBase<TModel>;

        public abstract List<ErrorMessage> ValidateFilterRequest<TFilterRequest, TFilterModel>(TFilterRequest request) where TFilterRequest : FilterRequestBase<TFilterModel>;

        public List<ErrorMessage> ValidateEmptyRequest<TEmptyRequest, TObject>(TEmptyRequest request) where TEmptyRequest : EmptyRequest
        {
            List<ErrorMessage> errors = new List<ErrorMessage>();
            switch (request.TipoDato)
            {
                case TipoParametro.Int:
                    if (request.Param == null)
                        errors.Add(new ErrorMessage { Description = Error.Int });
                    else if (request.Param.GetType() != typeof(int))
                        errors.Add(new ErrorMessage { Description = Error.Int });
                    else
                    {
                        if (!((int?)request.Param).HasValue)
                            errors.Add(new ErrorMessage { Description = Error.Int });
                    }
                    break;
                case TipoParametro.DateTime:
                    if (request.Param == null)
                        errors.Add(new ErrorMessage { Description = Error.DateTime });
                    else if (request.Param.GetType() != typeof(DateTime))
                        errors.Add(new ErrorMessage { Description = Error.DateTime });
                    else
                    {
                        if (!((DateTime?)request.Param).HasValue)
                            errors.Add(new ErrorMessage { Description = Error.DateTime });
                    }
                    break;
                case TipoParametro.String:
                    if (request.Param == null)
                        errors.Add(new ErrorMessage { Description = Error.String });
                    else if (request.Param.GetType() != typeof(string))
                        errors.Add(new ErrorMessage { Description = Error.String });
                    else
                    {
                        if (string.IsNullOrEmpty((string)request.Param))
                            errors.Add(new ErrorMessage { Description = Error.String });
                    }
                    break;
                case TipoParametro.Bool:
                    if (request.Param == null)
                        errors.Add(new ErrorMessage { Description = Error.Bool });
                    else if (request.Param.GetType() != typeof(bool))
                        errors.Add(new ErrorMessage { Description = Error.Bool });
                    else
                    {
                        if (!((bool?)request.Param).HasValue)
                            errors.Add(new ErrorMessage { Description = Error.Bool });
                    }
                    break;
                case TipoParametro.Decimal:
                    if (request.Param == null)
                        errors.Add(new ErrorMessage { Description = Error.Decimal });
                    else if (request.Param.GetType() != typeof(decimal))
                        errors.Add(new ErrorMessage { Description = Error.Decimal });
                    else
                    {
                        if (!((decimal?)request.Param).HasValue)
                            errors.Add(new ErrorMessage { Description = Error.Decimal });
                    }
                    break;
                case TipoParametro.Double:
                    if (request.Param == null)
                        errors.Add(new ErrorMessage { Description = Error.Double });
                    else if (request.Param.GetType() != typeof(double))
                        errors.Add(new ErrorMessage { Description = Error.Double });
                    else
                    {
                        if (!((double?)request.Param).HasValue)
                            errors.Add(new ErrorMessage { Description = Error.Double });
                    }
                    break;
                case TipoParametro.Long:
                    if (request.Param == null)
                        errors.Add(new ErrorMessage { Description = Error.Long });
                    else if (request.Param.GetType() != typeof(long))
                        errors.Add(new ErrorMessage { Description = Error.Long });
                    else
                    {
                        if (!((long?)request.Param).HasValue)
                            errors.Add(new ErrorMessage { Description = Error.Long });
                    }
                    break;
            }

            return errors;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
