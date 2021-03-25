using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        public IResult MakePayment(Payment payment)
        {
            if (payment.Amount>8000)
            {
                return new ErrorResult("test fail");
            }
            return new SuccessResult("test success");
        }
    }
}
