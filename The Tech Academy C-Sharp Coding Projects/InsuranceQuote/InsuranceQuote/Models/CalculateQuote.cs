using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceQuote.Models
{
    public class CalculateQuote
    {
        public static int userAge(InsuranceGetQuote model)
        {
            var today = DateTime.Today;
            var age = today.Year - model.DateBirth.Year;
            return age;

        }
        public static int calculation(InsuranceGetQuote model)
        {
            int quoteBase = 50;

            if (userAge(model) < 25)
            {
                quoteBase += 25;
            }

            if (userAge(model) < 18)
            {
                quoteBase += 100;
            }

            if (userAge(model) > 100)
            {
                quoteBase += 25;
            }

            if (model.CarYear < 2000)
            {
                quoteBase += 25;
            }

            if (model.CarYear > 2015)
            {
                quoteBase += 25;
            }

            if (model.CarMake == "Porsche")
            {
                quoteBase += 25;
            }

            if (model.CarMake == "Porsche" && model.CarModel == "911 Carrera")
            {
                quoteBase += 25;
            }

            quoteBase += 10 * model.Ticket;

            if (model.DUI)
            {
                quoteBase += quoteBase * (1/4);
            }

            if (model.FullCover)
            {
                quoteBase += quoteBase * (1/2);
            }

            return quoteBase;
        }
    }
}