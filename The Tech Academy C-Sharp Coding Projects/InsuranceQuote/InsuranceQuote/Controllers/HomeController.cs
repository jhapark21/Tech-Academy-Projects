using InsuranceQuote.Models;
using InsuranceQuote.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace InsuranceQuote.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InsuranceQuote;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime dateBirth, int carYear, string carMake, string carModel, int ticket, Boolean dUI = false, Boolean fullCover = false)
        {
            InsuranceGetQuote insQuote = new InsuranceGetQuote();
            insQuote.FirstName = firstName;
            insQuote.LastName = lastName;
            insQuote.EmailAddress = emailAddress;
            insQuote.DateBirth = dateBirth;
            insQuote.CarYear = carYear;
            insQuote.CarMake = carMake;
            insQuote.CarModel = carModel;
            insQuote.Ticket = ticket;
            insQuote.DUI = dUI;
            insQuote.FullCover = fullCover;


            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                insQuote.QuotePrice = CalculateQuote.calculation(insQuote);

                string queryString = @"INSERT INTO GetQuotes (FirstName, LastName, EmailAddress, DateBirth, CarYear, CarMake, CarModel, Ticket, DUI, FullCover, QuotePrice) VALUES
                                        (@FirstName, @LastName, @EmailAddress, @DateBirth, @CarYear, @CarMake, @CarModel, @Ticket, @DUI, @FullCover @QuotePrice)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@DateBirth", SqlDbType.Date);
                    command.Parameters.Add("@CarYear", SqlDbType.Int);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@Ticket", SqlDbType.Int);
                    command.Parameters.Add("@DUI", SqlDbType.Bit);
                    command.Parameters.Add("@FullCover", SqlDbType.Bit);
                    command.Parameters.Add("@QuotePrice", SqlDbType.Float);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    command.Parameters["@DateBirth"].Value = dateBirth;
                    command.Parameters["@CarYear"].Value = carYear;
                    command.Parameters["@CarMake"].Value = carMake;
                    command.Parameters["@CarModel"].Value = carModel;
                    command.Parameters["@Ticket"].Value = ticket;
                    command.Parameters["@DUI"].Value = dUI;
                    command.Parameters["@FullCover"].Value = fullCover;
                    command.Parameters["@QuotePrice"].Value = insQuote.QuotePrice;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return View("Success");
            }
        }
        
        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, DateBirth, CarYear, CarMake, CarModel, Ticket, DUI, FullCover, QuotePrice from GetQuotes";
            List<InsuranceGetQuote> quotes = new List<InsuranceGetQuote>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var quote = new InsuranceGetQuote();
                    quote.Id = Convert.ToInt32(reader["Id"]);
                    quote.FirstName = reader["FirstName"].ToString();
                    quote.LastName = reader["LastName"].ToString();
                    quote.EmailAddress = reader["EmailAddress"].ToString();
                    quote.DateBirth = Convert.ToDateTime(reader["DateBirth"]).Date;
                    quote.CarYear = Convert.ToInt32(reader["CarYear"]);
                    quote.CarMake = reader["CarMake"].ToString();
                    quote.CarModel = reader["CarModel"].ToString();
                    quote.Ticket = Convert.ToInt32(reader["Ticket"]);
                    quote.DUI = Convert.ToBoolean(reader["DUI"]);
                    quote.FullCover = Convert.ToBoolean(reader["FullCover"]);
                    quote.QuotePrice = Convert.ToSingle(reader["QuotePrice"]);
                    quotes.Add(quote);
                }
            }
            var quoteVms = new List<QuoteVm>();
            foreach (var quote in quotes)
            {
                var quoteVm = new QuoteVm();
                quoteVm.FirstName = quote.FirstName;
                quoteVm.LastName = quote.LastName;
                quoteVm.EmailAddress = quote.EmailAddress;
                quoteVm.DateBirth = quote.DateBirth;
                quoteVm.CarYear = quote.CarYear;
                quoteVm.CarMake = quote.CarMake;
                quoteVm.CarModel = quote.CarModel;
                quoteVm.Ticket = quote.Ticket;
                quoteVm.DUI = quote.DUI;
                quoteVm.FullCover = quote.FullCover;
                quoteVm.QuotePrice = quote.QuotePrice;
                quoteVms.Add(quoteVm);
            }

            return View(quoteVms);
        }
    }
}