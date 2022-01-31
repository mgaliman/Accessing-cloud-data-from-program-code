using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using WPF_CRUD.Models;
using WPF_CRUD.Utils;
using WPF_CRUD.ViewModels;

namespace WPF_CRUD.Dal
{
    class SqlRepository : IRepository
    {
        private const string FirstNameParam = "@firstname";
        private const string LastNameParam = "@lastname";
        private const string AgeParam = "@age";
        private const string EmailParam = "@email";
        private const string PictureParam = "@picture";
        private const string IdPersonParam = "@idPerson";
        private const string ProfessionnIdParam = "@professionid";
        private const string ProfessionnNameParam = "@professionname";

        private const string ProfessionNameParam = "@professionname";
        private const string IdProfessionParam = "@idProfession";

        // cannot be const
        //private static readonly string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private static readonly string cs = EncryptionUtils.Decrypt(ConfigurationManager.ConnectionStrings["cs"].ConnectionString, "fru1tc@k3");

        public void AddPerson(Person person)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(FirstNameParam, person.FirstName);
                    cmd.Parameters.AddWithValue(LastNameParam, person.LastName);
                    cmd.Parameters.AddWithValue(AgeParam, person.Age);
                    cmd.Parameters.AddWithValue(EmailParam, person.Email);                    
                    cmd.Parameters.Add(new SqlParameter(PictureParam, SqlDbType.Binary, person.Picture.Length)
                    {
                        Value = person.Picture
                    });
                    cmd.Parameters.AddWithValue(ProfessionnIdParam, person.ProfessionID);
                    cmd.Parameters.AddWithValue(ProfessionnNameParam, person.ProfessionName);
                    SqlParameter idPerson = new SqlParameter(IdPersonParam, SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(idPerson);
                    cmd.ExecuteNonQuery();
                    person.IDPerson = (int)idPerson.Value;
                }
            }
        }

        public void DeletePerson(Person person)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(IdPersonParam, person.IDPerson);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IList<Person> GetPeople()
        {
            IList<Person> people = new List<Person>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            people.Add(ReadPerson(dr));
                        }
                    }
                }
            }
            return people;
        }

        public Person GetPerson(int idPerson)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(IdPersonParam, idPerson);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return ReadPerson(dr);
                        }
                    }
                }
            }
            throw new Exception("Person does not exist");
        }

        private Person ReadPerson(SqlDataReader dr) => new Person
        {
            IDPerson = (int)dr[nameof(Person.IDPerson)],
            FirstName = dr[nameof(Person.FirstName)].ToString(),
            LastName = dr[nameof(Person.LastName)].ToString(),
            Age = (int)dr[nameof(Person.Age)],
            Email = dr[nameof(Person.Email)].ToString(),
            Picture = ImageUtils.ByteArrayFromSqlDataReader(dr, 5),
            ProfessionID = (int)dr[nameof(Person.ProfessionID)],
            ProfessionName = dr[nameof(Person.ProfessionName)].ToString()
        };

        public void UpdatePerson(Person person)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(FirstNameParam, person.FirstName);
                    cmd.Parameters.AddWithValue(LastNameParam, person.LastName);
                    cmd.Parameters.AddWithValue(AgeParam, person.Age);
                    cmd.Parameters.AddWithValue(EmailParam, person.Email);
                    cmd.Parameters.AddWithValue(IdPersonParam, person.IDPerson);
                    cmd.Parameters.AddWithValue(ProfessionnIdParam, person.ProfessionID);
                    cmd.Parameters.Add(new SqlParameter(PictureParam, SqlDbType.Binary, person.Picture.Length)
                    {
                        Value = person.Picture
                    });
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddProfession(Profession profession)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(ProfessionNameParam, profession.ProfessionName);
                    SqlParameter idProfession = new SqlParameter(IdProfessionParam, SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(idProfession);
                    cmd.ExecuteNonQuery();
                    profession.IDProfession = (int)idProfession.Value;
                }
            }
        }

        public void DeleteProfession(Profession profession)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(IdProfessionParam, profession.IDProfession);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IList<Profession> GetProfessions()
        {
            IList<Profession> professions = new List<Profession>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            professions.Add(ReadProfession(dr));
                        }
                    }
                }
            }
            return professions;
        }

        public Profession GetProfession(int idProfession)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(IdProfessionParam, idProfession);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return ReadProfession(dr);
                        }
                    }
                }
            }
            throw new Exception("Profession does not exist");
        }

        private Profession ReadProfession(SqlDataReader dr) => new Profession
        {
            IDProfession = (int)dr[nameof(Profession.IDProfession)],
            ProfessionName = dr[nameof(Profession.ProfessionName)].ToString()
        };

        public void UpdateProfession(Profession profession)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = MethodBase.GetCurrentMethod().Name;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(ProfessionNameParam, profession.ProfessionName);
                    cmd.Parameters.AddWithValue(IdProfessionParam, profession.IDProfession);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}